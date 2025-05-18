CREATE PROCEDURE [dbo].[GetTaskById]
	@Id int 
	
AS
BEGIN
	SELECT * FROM Task
	WHERE Id = @Id
END
