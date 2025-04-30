CREATE TABLE [dbo].[Project]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50) NOT NULL,
	[Description] NVARCHAR(MAX) NULL, 
    [StatusId] INT NOT NULL,
	[PriorityId] INT NOT NULL,
	[StartDate] DateTime NULL,
	[FinishDate] DateTime NULL, 
    [Private] BIT NOT NULL DEFAULT 0, 
    [HasTasks] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_Project_Status] FOREIGN KEY ([StatusId]) REFERENCES [Status]([Id]), 
    CONSTRAINT [FK_Project_Priority] FOREIGN KEY ([PriorityId]) REFERENCES [Priority]([Id]),

	





)
