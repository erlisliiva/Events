CREATE TABLE [dbo].[Person]
(
	[PersonId] INT NOT NULL PRIMARY KEY IDENTITY, 
	[PersonFK] INT NOT NULL,
	[IsBusiness] BIT NOT NULL,
    [FirstName] NCHAR(50) NOT NULL, 
    [LastName] NCHAR(50) NOT NULL, 
    [PersonalCode] NCHAR(25) NOT NULL, 
    [PayingMethod] NCHAR(50) NOT NULL, 
    [Info] NCHAR(100) NULL,
	CONSTRAINT [FK_Person_ToEvent] FOREIGN KEY (PersonFK) REFERENCES [Event]([Id])
)
