IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Forums] ( 
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_Forums] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Topics] (
    [Id] int NOT NULL IDENTITY,
    [Subject] nvarchar(max) NULL,
    [Content] nvarchar(max) NULL,
    [time] datetime2 NOT NULL,
    [ForumId] int NOT NULL,
    CONSTRAINT [PK_Topics] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Topics_Forums_ForumId] FOREIGN KEY ([ForumId]) REFERENCES [Forums] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [Replies] (
    [Id] int NOT NULL IDENTITY,
    [Rep] nvarchar(max) NULL,
    [TopicId] int NOT NULL,
    [time] datetime2 NOT NULL,
    CONSTRAINT [PK_Replies] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Replies_Topics_TopicId] FOREIGN KEY ([TopicId]) REFERENCES [Topics] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Replies_TopicId] ON [Replies] ([TopicId]);

GO

CREATE INDEX [IX_Topics_ForumId] ON [Topics] ([ForumId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190723060235_InitialSchema', N'2.2.4-servicing-10062');

GO

