using System.Text.RegularExpressions;
using Microsoft.Extensions.Logging;

namespace SignatureService.Engine;

/// <summary>
/// Detects the boundary between a user's new content and the quoted
/// reply/forward thread in both HTML and plain text email bodies.
///
/// The boundary is the character index where the quoted content begins.
/// The signature should be inserted immediately before this index.
///
/// Detection uses a priority-ordered cascade of patterns, covering
/// Outlook (desktop, web, Mac), Gmail, Apple Mail, Thunderbird,
/// and generic quoting conventions.
/// </summary>
public class ReplyBoundaryDetector
{
    private readonly ILogger<ReplyBoundaryDetector> _logger;

    public ReplyBoundaryDetector(ILogger<ReplyBoundaryDetector> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Finds the insertion point in an HTML body — the index where the
    /// quoted reply/forward content begins.
    /// Returns -1 if no reply boundary is found (message is a fresh compose).
    /// </summary>
    public HtmlBoundaryResult FindHtmlBoundary(string html)
    {
        // Priority-ordered: most specific first, most common clients first
        foreach (var detector in _htmlDetectors)
        {
            var index = detector.Find(html);
            if (index >= 0)
            {
                _logger.LogDebug("HTML boundary detected by {Detector} at index {Index}",
                    detector.Name, index);
                return new HtmlBoundaryResult(index, detector.Name);
            }
        }

        return HtmlBoundaryResult.NotFound;
    }

    /// <summary>
    /// Finds the insertion point in a plain text body.
    /// Returns -1 if no reply boundary is found.
    /// </summary>
    public PlainTextBoundaryResult FindPlainTextBoundary(string text)
    {
        foreach (var detector in _plainTextDetectors)
        {
            var match = detector.Regex.Match(text);
            if (match.Success)
            {
                _logger.LogDebug("Plain text boundary detected by {Detector} at index {Index}",
                    detector.Name, match.Index);
                return new PlainTextBoundaryResult(match.Index, detector.Name);
            }
        }

        return PlainTextBoundaryResult.NotFound;
    }

    // ========================================================================
    // HTML Detectors — priority ordered
    // ========================================================================

    private static readonly IReadOnlyList<HtmlDetector> _htmlDetectors = new HtmlDetector[]
    {
        // 1. OWA "append on send" marker — OWA inserts this explicitly for add-ins
        //    Also matches x_appendonsend (Exchange transport prefixes ids with x_)
        new("OWA-AppendOnSend",
            html => IndexOfTagWithXPrefix(html, "appendonsend")),

        // 2. Outlook reply/forward marker — covers Outlook Desktop, Web, Mac
        //    <div id="divRplyFwdMsg"> ... From/Sent/To/Subject headers
        //    Also matches x_divRplyFwdMsg (Exchange transport prefixes ids with x_)
        new("Outlook-divRplyFwdMsg",
            html => IndexOfTagWithXPrefix(html, "divRplyFwdMsg")),

        // 3. Outlook border-top separator variant
        //    Some Outlook versions use a border-top styled div instead of divRplyFwdMsg
        new("Outlook-BorderTop",
            html => IndexOfOutlookBorderSeparator(html)),

        // 4. Outlook <hr> with display:inline-block;width:98% followed by From/Sent headers
        //    Used by Exchange transport for forwarded meeting invites and some replies
        new("Outlook-HrInlineBlock",
            html => IndexOfOutlookHrInlineBlock(html)),

        // 5. Gmail quoted reply — <div class="gmail_quote">
        new("Gmail-Quote",
            html => IndexOfTag(html, "class=\"gmail_quote\"")),

        // 6. Gmail attribution line — <div class="gmail_attr"> "On ... wrote:"
        //    Sometimes appears without gmail_quote wrapper
        new("Gmail-Attribution",
            html => IndexOfTag(html, "class=\"gmail_attr\"")),

        // 7. Thunderbird citation prefix — <div class="moz-cite-prefix">
        new("Thunderbird-MozCite",
            html => IndexOfTag(html, "class=\"moz-cite-prefix\"")),

        // 8. Generic blockquote with cite — Apple Mail, some others
        //    <blockquote type="cite">
        new("Generic-BlockquoteCite",
            html => IndexOfTag(html, "type=\"cite\"")),

        // 9. "Original Message" text marker inside HTML
        new("OriginalMessage-Text",
            html => IndexOfOriginalMessageHtml(html)),

        // 10. Yahoo Mail — <div class="yahoo_quoted">
        new("Yahoo-Quoted",
            html => IndexOfTag(html, "class=\"yahoo_quoted\"")),

        // 11. Generic "wrote:" pattern in HTML (last resort for HTML)
        new("Generic-WrotePattern",
            html => IndexOfWrotePatternHtml(html)),
    };

    // ========================================================================
    // Plain Text Detectors — priority ordered
    // ========================================================================

    private static readonly IReadOnlyList<PlainTextDetector> _plainTextDetectors = new PlainTextDetector[]
    {
        // 1. Outlook: "-----Original Message-----"
        new("Outlook-OriginalMessage",
            new Regex(@"^-{2,}\s*Original Message\s*-{2,}\s*$",
                RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Compiled)),

        // 2. Outlook: "From: <address>" at start of line (reply/forward headers)
        new("Outlook-FromHeader",
            new Regex(@"^From:\s+.+@.+\..+$",
                RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Compiled)),

        // 3. "On <date>, <person> wrote:" — Gmail, Apple Mail, Thunderbird
        new("Generic-OnWrote",
            new Regex(@"^On\s.+wrote:\s*$",
                RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Compiled)),

        // 4. Localized variants: "Le <date>, <person> a écrit :" (French)
        //    "Am <date> schrieb <person>:" (German)
        new("Localized-Wrote",
            new Regex(@"^(Le\s.+a\s+(é|e)crit\s*:|Am\s.+schrieb\s.+:|El\s.+escribi(ó|o)\s*:|.+написал.+:)\s*$",
                RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Compiled)),

        // 5. Angle-bracket quoting (oldest convention)
        //    First line starting with > after non-> content
        new("Generic-AngleBracket",
            new Regex(@"(?<=\n[^>]*\n)^>+\s",
                RegexOptions.Multiline | RegexOptions.Compiled)),

        // 6. Separator lines ("___" or "---" at least 5 chars)
        new("Generic-Separator",
            new Regex(@"^[_\-=]{5,}\s*$",
                RegexOptions.Multiline | RegexOptions.Compiled)),
    };

    // ========================================================================
    // Helper methods for HTML detection
    // ========================================================================

    /// <summary>
    /// Finds the start of the opening tag that contains the given attribute substring.
    /// Returns the index of the '<' that starts the tag, or -1.
    /// </summary>
    private static int IndexOfTag(string html, string attributeFragment)
    {
        var attrIndex = html.IndexOf(attributeFragment, StringComparison.OrdinalIgnoreCase);
        if (attrIndex < 0) return -1;

        // Walk backward to find the opening '<'
        for (var i = attrIndex; i >= 0; i--)
        {
            if (html[i] == '<') return i;
        }

        return -1;
    }

    /// <summary>
    /// Finds a tag by its id attribute, also matching the x_ prefixed variant.
    /// Exchange transport prefixes element ids with "x_" when embedding content,
    /// so id="divRplyFwdMsg" becomes id="x_divRplyFwdMsg".
    /// Returns the index of the outermost (first) occurrence.
    /// </summary>
    private static int IndexOfTagWithXPrefix(string html, string idValue)
    {
        var idx1 = IndexOfTag(html, $"id=\"{idValue}\"");
        var idx2 = IndexOfTag(html, $"id=\"x_{idValue}\"");

        if (idx1 < 0) return idx2;
        if (idx2 < 0) return idx1;
        return Math.Min(idx1, idx2);
    }

    // Regex matching border-top:solid with any hex color — covers all Outlook versions
    // without needing to hardcode specific colors like #E1E1E1, #B5C4DF, #DEDEDE, etc.
    private static readonly Regex _borderTopRegex = new(
        @"border-top\s*:\s*solid\s+#[0-9a-fA-F]{3,6}",
        RegexOptions.Compiled);

    // Reply/forward header labels that should follow the border separator
    private static readonly string[] _replyHeaderLabels =
        ["From:", "Od:", "Von:", "De:", "Від:", "Sent:", "Odesláno:", "Wysłano:", "Gesendet:"];

    /// <summary>
    /// Detects Outlook's border-top separator pattern:
    /// A div/p with inline style containing "border-top:solid #xxxxxx"
    /// followed by From:/Sent:/To: reply headers within 500 chars.
    /// Uses a regex to match any hex color instead of a hardcoded list.
    /// </summary>
    private static int IndexOfOutlookBorderSeparator(string html)
    {
        var match = _borderTopRegex.Match(html);
        while (match.Success)
        {
            // Verify this is a reply separator, not a table/layout border,
            // by checking for From:/Sent: headers within the next 500 chars
            var afterIdx = match.Index + match.Length;
            var lookAhead = html.AsSpan(afterIdx, Math.Min(500, html.Length - afterIdx));

            var hasReplyHeader = false;
            foreach (var label in _replyHeaderLabels)
            {
                if (lookAhead.Contains(label, StringComparison.OrdinalIgnoreCase))
                {
                    hasReplyHeader = true;
                    break;
                }
            }

            if (hasReplyHeader)
            {
                // Walk backward to find the containing element's '<'
                var searchStart = Math.Max(0, match.Index - 200);
                var fragment = html[searchStart..match.Index];
                var divIdx = fragment.LastIndexOf("<div", StringComparison.OrdinalIgnoreCase);
                if (divIdx >= 0)
                {
                    return searchStart + divIdx;
                }

                for (var i = match.Index; i >= 0; i--)
                {
                    if (html[i] == '<') return i;
                }
            }

            match = match.NextMatch();
        }

        return -1;
    }

    // Regex matching <hr with display:inline-block and width:98%
    private static readonly Regex _hrInlineBlockRegex = new(
        @"<hr\b[^>]*display\s*:\s*inline-block[^>]*width\s*:\s*98%[^>]*>",
        RegexOptions.IgnoreCase | RegexOptions.Compiled);

    /// <summary>
    /// Detects Outlook's bare HR separator used by Exchange transport:
    /// &lt;hr tabindex="-1" style="display:inline-block; width:98%"&gt;
    /// followed by From:/Sent: reply headers within 300 chars.
    /// </summary>
    private static int IndexOfOutlookHrInlineBlock(string html)
    {
        var match = _hrInlineBlockRegex.Match(html);
        while (match.Success)
        {
            // Verify reply headers follow
            var afterIdx = match.Index + match.Length;
            var lookAhead = html.AsSpan(afterIdx, Math.Min(300, html.Length - afterIdx));

            var hasReplyHeader = false;
            foreach (var label in _replyHeaderLabels)
            {
                if (lookAhead.Contains(label, StringComparison.OrdinalIgnoreCase))
                {
                    hasReplyHeader = true;
                    break;
                }
            }

            if (hasReplyHeader)
            {
                return match.Index;
            }

            match = match.NextMatch();
        }

        return -1;
    }

    /// <summary>
    /// Finds "Original Message" or "Forwarded Message" text inside HTML.
    /// Looks for the text inside any element, returns the start of that element.
    /// </summary>
    private static int IndexOfOriginalMessageHtml(string html)
    {
        var patterns = new[]
        {
            "Original Message",
            "Forwarded Message",
            "Forwarded message",
        };

        foreach (var pattern in patterns)
        {
            var textIdx = html.IndexOf(pattern, StringComparison.OrdinalIgnoreCase);
            if (textIdx < 0) continue;

            // Check that it's surrounded by dashes (the standard Outlook format)
            var lineStart = html.LastIndexOf('\n', Math.Max(0, textIdx - 1));
            if (lineStart < 0) lineStart = 0;
            var lineContent = html[lineStart..textIdx];
            if (!lineContent.Contains('-')) continue;

            // Walk backward to find the containing element's '<'
            for (var i = lineStart; i >= 0; i--)
            {
                if (html[i] == '<') return i;
            }

            return lineStart;
        }

        return -1;
    }

    /// <summary>
    /// Detects "On ... wrote:" pattern rendered in HTML.
    /// This is the fallback for clients that don't use well-known class names.
    /// </summary>
    private static int IndexOfWrotePatternHtml(string html)
    {
        // Pattern: text node containing "On " ... "wrote:" possibly spanning elements
        var regex = new Regex(
            @"<(div|p|span)[^>]*>\s*On\s.{10,200}wrote:\s*</(div|p|span)>",
            RegexOptions.IgnoreCase | RegexOptions.Singleline);

        var match = regex.Match(html);
        return match.Success ? match.Index : -1;
    }
}

// ========================================================================
// Types
// ========================================================================

internal class HtmlDetector
{
    public string Name { get; }
    private readonly Func<string, int> _findFunc;

    public HtmlDetector(string name, Func<string, int> findFunc)
    {
        Name = name;
        _findFunc = findFunc;
    }

    public int Find(string html) => _findFunc(html);
}

internal class PlainTextDetector
{
    public string Name { get; }
    public Regex Regex { get; }

    public PlainTextDetector(string name, Regex regex)
    {
        Name = name;
        Regex = regex;
    }
}

public record HtmlBoundaryResult(int Index, string DetectorName)
{
    public bool Found => Index >= 0;
    public static readonly HtmlBoundaryResult NotFound = new(-1, "None");
}

public record PlainTextBoundaryResult(int Index, string DetectorName)
{
    public bool Found => Index >= 0;
    public static readonly PlainTextBoundaryResult NotFound = new(-1, "None");
}
