CREATE PROCEDURE [dbo].[GetIdeaById]
	@Id int
	
AS
BEGIN
	SELECT * FROM ProjectIdea
	WHERE Id = @Id
END
