#!/bin/sh
set -e

COMMON="--folders SentItems --folders Inbox --max 1000 --tenant b39be806-f458-4882-ac82-da45ea007f9a --client-id daba81b1-ef3f-43a7-a5fd-87b4805fc326 --templates /app/templates"

MAILBOXES="
david.kovarik@invia.com
dawid.jerzykowski@invia.com
jiri.urbanek@invia.com
petr.vysokomensky@invia.com
filip.masarik@invia.com
jakub.krkoska@invia.com
"

for mb in $MAILBOXES; do
  SAFE=$(echo "$mb" | cut -d@ -f1 | tr '.' '-')
  echo "=========================================="
  echo "SCANNING: $mb -> /app/output/$SAFE"
  echo "=========================================="
  dotnet /app/SignatureAnalyzer.dll --mailbox "$mb" $COMMON --output "/app/output/$SAFE" || echo "FAILED: $mb"
done

echo "=========================================="
echo "ALL DONE"
echo "=========================================="
