CREATE PROCEDURE [dbo].[GetProjectById]
	@Id int
	
AS
BEGIN
	SELECT * FROM Project
	WHERE Id = @Id
END
