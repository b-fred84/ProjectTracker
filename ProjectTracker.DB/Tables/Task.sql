CREATE TABLE [dbo].[Task]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProjectId] INT NOT NULL,
    [Name] NVARCHAR(150) NOT NULL, 
    [Details] NVARCHAR(MAX) NULL, 
    [StatusId] INT NOT NULL, 
    [PriorityId] INT NOT NULL, 
    [StartDate] DATE NULL, 
    [FinishDate] DATE NULL, 
    [Private] BIT NULL DEFAULT 0, 
    CONSTRAINT [FK_Task_ToProject] FOREIGN KEY ([ProjectId]) REFERENCES [Project]([Id]), 
    CONSTRAINT [FK_Task_Status] FOREIGN KEY ([StatusId]) REFERENCES [Status]([Id]), 
    CONSTRAINT [FK_Task_Priority] FOREIGN KEY ([PriorityId]) REFERENCES [Priority]([Id])
  
   
    
)
