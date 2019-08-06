CREATE TABLE [dbo].[Employeers] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (50)  NOT NULL,
    [Surname]   NVARCHAR (50)  NOT NULL,
    [Adress]    NVARCHAR (50)  NOT NULL,
    [City]      NVARCHAR (50)  NOT NULL,
    [Email]     NVARCHAR (MAX) NOT NULL,
    [Password]  NVARCHAR (MAX) NOT NULL
);