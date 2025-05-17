CREATE PROCEDURE [dbo].[GetAllTasks]
	@ProjectId int = NULL,
	@StatusId int = NULL,
	@PriorityId int = NULL,
	@SortBy nvarchar(50) = 'Name',
	@SortOrder nvarchar(4) = 'ASC'
AS
BEGIN
	SELECT 
	t.*,
	p.[Name] AS ProjectName
	FROM [Task] t
	INNER JOIN [Project] p ON t.ProjectId = p.Id
	WHERE
	(@ProjectId IS NULL OR t.ProjectId = @ProjectId)
	AND (@StatusId IS NULL OR t.StatusId = @StatusId)
	AND (@PriorityId IS NULL OR t.PriorityId = @PriorityId) 
	ORDER BY
	    CASE WHEN @SortBy = 'Name' AND @SortOrder = 'ASC' THEN t.[Name] END ASC,
		CASE WHEN @SortBy = 'Name' AND @SortOrder = 'DESC' THEN t.[Name] END DESC,
		CASE WHEN @SortBy = 'ProjectName' AND @SortOrder = 'ASC' THEN p.[Name] END ASC,
		CASE WHEN @SortBy = 'ProjectName' AND @SortOrder = 'DESC' THEN P.[Name] END DESC,
		CASE WHEN @SortBy = 'StatusId' AND @SortOrder = 'ASC' THEN t.StatusId END ASC,
		CASE WHEN @SortBy = 'StatusId' AND @SortOrder = 'DESC' THEN t.StatusId END DESC,
		CASE WHEN @SortBy = 'PriorityId' AND @SortOrder = 'ASC' THEN t.PriorityId END ASC,
		CASE WHEN @SortBy = 'PriorityId' AND @SortOrder = 'DESC' THEN t.PriorityId END DESC,
        CASE WHEN @SortBy = 'StartDate' AND @SortOrder = 'ASC' THEN t.StartDate END ASC,
        CASE WHEN @SortBy = 'StartDate' AND @SortOrder = 'DESC' THEN t.StartDate END DESC,
        CASE WHEN @SortBy = 'FinishDate' AND @SortOrder = 'ASC' THEN t.FinishDate END ASC,
        CASE WHEN @SortBy = 'FinishDate' AND @SortOrder = 'DESC' THEN t.FinishDate END DESC;
END
