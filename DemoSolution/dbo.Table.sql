CREATE TABLE [dbo].[Clients]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [Surname] NVARCHAR(50) NOT NULL, 
    [PlateName] NVARCHAR(8) NULL, 
    [CreatedAt] DATETIME2 NOT NULL, 
    [CreatedBy] NVARCHAR(50) NOT NULL
)
