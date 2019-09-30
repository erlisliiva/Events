CREATE TABLE [dbo].[Event] (
    [Id]        INT         PRIMARY KEY NOT NULL,
    [EventName] NCHAR (100) NOT NULL,
    [StartDate] DATETIME    NOT NULL,
    [Location]  NCHAR (100) NOT NULL,
    [Info]      NCHAR (255) NULL
);

