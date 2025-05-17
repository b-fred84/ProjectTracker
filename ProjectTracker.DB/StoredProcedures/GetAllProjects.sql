CREATE PROCEDURE [dbo].[GetAllProjects]
	@StatusId int = NULL,
	@PriorityId int = NULL,
	@SortBy nvarchar(50) = 'Name',
	@SortOrder NVARCHAR(4) = 'ASC'
AS
BEGIN
	SELECT *
	FROM Project
	WHERE
	(@StatusId IS NULL OR StatusId = @StatusId)
	AND (@PriorityId IS NULL OR PriorityId = @PriorityId)
	ORDER BY
	    CASE WHEN @SortBy = 'Name' AND @SortOrder = 'ASC' THEN [Name] END ASC,
        CASE WHEN @SortBy = 'Name' AND @SortOrder = 'DESC' THEN [Name] END DESC,
		CASE WHEN @SortBy = 'StatusId' AND @SortOrder = 'ASC' THEN StatusId END ASC,
		CASE WHEN @SortBy = 'StatusId' AND @SortOrder = 'DESC' THEN StatusId END DESC,
		CASE WHEN @SortBy = 'PriorityId' AND @SortOrder = 'ASC' THEN PriorityId END ASC,
		CASE WHEN @SortBy = 'PriorityId' AND @SortOrder = 'DESC' THEN PriorityId END DESC,
        CASE WHEN @SortBy = 'StartDate' AND @SortOrder = 'ASC' THEN StartDate END ASC,
        CASE WHEN @SortBy = 'StartDate' AND @SortOrder = 'DESC' THEN StartDate END DESC,
        CASE WHEN @SortBy = 'FinishDate' AND @SortOrder = 'ASC' THEN FinishDate END ASC,
        CASE WHEN @SortBy = 'FinishDate' AND @SortOrder = 'DESC' THEN FinishDate END DESC
END
