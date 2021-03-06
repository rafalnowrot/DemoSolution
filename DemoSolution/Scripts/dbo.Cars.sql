﻿CREATE TABLE [dbo].[Cars]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BrandName] NVARCHAR(50) NOT NULL,
    [Model] NVARCHAR(50) NOT NULL, 
	[ClientId] INT NOT NULL, 
	[CreatedBy] NVARCHAR(50) NOT NULL, 
    [CreatedAt] DATETIME2 NOT NULL, 
    FOREIGN KEY (ClientId) REFERENCES Clients(Id)
)