CREATE TABLE [dbo].[ProjectIdea]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [Notes] NVARCHAR(MAX) NULL,

)
