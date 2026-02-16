-- ============================================================
-- SQL Schema for SmtpToSql
-- Run this against your CRM database (or a dedicated database)
-- ============================================================

-- Phase 1 table: Raw message storage (the durable queue)
-- This is the critical table that ensures no messages are lost.
CREATE TABLE RawMessages (
    Id              UNIQUEIDENTIFIER PRIMARY KEY,
    RawMessage      VARBINARY(MAX)   NOT NULL,
    EnvelopeFrom    NVARCHAR(500)    NOT NULL,
    EnvelopeTo      NVARCHAR(2000)   NOT NULL,
    ReceivedUtc     DATETIME2        NOT NULL,
    Status          INT              NOT NULL DEFAULT 0,   -- 0 = Pending, 1 = Processed
    RetryCount      INT              NOT NULL DEFAULT 0,
    LastError       NVARCHAR(MAX)    NULL,
    LastRetryUtc    DATETIME2        NULL,
    ProcessedUtc    DATETIME2        NULL
);

-- Index for the processing worker to efficiently find pending messages
CREATE NONCLUSTERED INDEX IX_RawMessages_Pending
    ON RawMessages (Status, RetryCount, ReceivedUtc)
    WHERE Status = 0 AND RetryCount < 10;

-- Phase 2 table: Parsed email data for CRM consumption
-- Adapt this to match your existing CRM email table schema.
CREATE TABLE CrmEmails (
    Id              UNIQUEIDENTIFIER PRIMARY KEY,
    MessageId       NVARCHAR(1000)   NOT NULL DEFAULT '',
    InReplyTo       NVARCHAR(1000)   NOT NULL DEFAULT '',
    [From]          NVARCHAR(2000)   NOT NULL,
    [To]            NVARCHAR(4000)   NOT NULL,
    Cc              NVARCHAR(4000)   NOT NULL DEFAULT '',
    Subject         NVARCHAR(1000)   NOT NULL DEFAULT '',
    DateUtc         DATETIME2        NOT NULL,
    TextBody        NVARCHAR(MAX)    NOT NULL DEFAULT '',
    HtmlBody        NVARCHAR(MAX)    NOT NULL DEFAULT '',
    RawMessage      VARBINARY(MAX)   NOT NULL,
    EnvelopeFrom    NVARCHAR(500)    NOT NULL,
    EnvelopeTo      NVARCHAR(2000)   NOT NULL,
    ReceivedUtc     DATETIME2        NOT NULL,
    CreatedUtc      DATETIME2        NOT NULL DEFAULT GETUTCDATE()
);

-- Index for CRM queries (adjust based on your CRM's access patterns)
CREATE NONCLUSTERED INDEX IX_CrmEmails_Date
    ON CrmEmails (DateUtc DESC);

CREATE NONCLUSTERED INDEX IX_CrmEmails_MessageId
    ON CrmEmails (MessageId)
    WHERE MessageId <> '';

-- Optional: Cleanup job for old raw messages (after processing)
-- You can run this periodically to keep the RawMessages table lean.
-- DELETE FROM RawMessages WHERE Status = 1 AND ProcessedUtc < DATEADD(DAY, -7, GETUTCDATE());
