CREATE PROCEDURE [dbo].[GetAllIdeas]
   @SortBy nvarchar(50) = 'Name',
   @SortOrder nvarchar(4) = 'ASC' 

AS
BEGIN
	SELECT * FROM ProjectIdea
	ORDER BY
	   CASE WHEN @SortBy = 'Name' AND @SortOrder = 'ASC' THEN [Name] END ASC,
	   CASE WHEN @SortBy = 'Name' AND @SortOrder = 'DESC' THEN [Name] END DESC
END
