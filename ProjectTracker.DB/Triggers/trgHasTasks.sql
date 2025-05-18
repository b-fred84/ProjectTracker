CREATE TRIGGER [dbo].[SetHasTasks]
ON [dbo].[Task]
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
	UPDATE p
	SET HasTasks = CASE
			WHEN EXISTS (SELECT 1 FROM [Task] t WHERE t.ProjectId = p.Id) THEN 1 
			ELSE 0
			END
		FROM Project p;

END
