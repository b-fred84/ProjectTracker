using Dapper;
using ProjectTracker.Core.Interfaces.Data;
using ProjectTracker.Core.Interfaces.Repos;
using ProjectTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.DataAccess.Repositories
{
    public class TaskRepository : ITaskRepository
    {

        private readonly ISqlDataAccess _dbAccess;

        public TaskRepository(ISqlDataAccess dbAccess)
        {
            _dbAccess = dbAccess;
        }

        public async Task AddTaskAsync(TaskModel task)
        {
            var sqlQuery = @"INSERT INTO [Task] (ProjectId, Name, Details, StatusId, PriorityId, StartDate, FinishDate, Private)
                           VALUES (@ProjectId, @Name, @Details, @StatusId, @PriorityId, @StartDate, @FinishDate, @Private)";

            await _dbAccess.SaveDataAsync(sqlQuery, task);
        }
        //GetAll needed??? maybe just use getAllFileterable (then can rename to just GetAll)
        public async Task<IEnumerable<TaskModel>> GetAllTasksAsync()
        {
            return await _dbAccess.LoadDataAsync<TaskModel, dynamic>("dbo.GetAllTasks", new { });
        }

        public async Task<IEnumerable<TaskModel>> GetTasksFilterableAsync(int? projectId, int? statusId, int? priorityId,
                                                                     string sortBy, string sortOrder)
        {
            return await _dbAccess.LoadDataAsync<TaskModel, dynamic>(
                "dbo.GetAllTasks",
                new { ProjectId = projectId, StatusId = statusId, PriorityId = priorityId, SortBy = sortBy, SortOrder = sortOrder });
        }

        public async Task<TaskModel> GetTaskByIdAsync(int id)
        {
            var results = await _dbAccess.LoadDataAsync<TaskModel, dynamic> ("dbo.GetTaskById", new { Id = id });

            return results.FirstOrDefault();
        }

        public async Task UpdateTaskAsync(TaskModel task)
        {
            var sqlQuery = @"UPDATE [Task]
                             SET 
                                ProjectId = @ProjectId,
                                Name = @Name, 
                                Details = @Details, 
                                StatusId = @StatusId, 
                                PriorityId = @PriorityId, 
                                StartDate = @StartDate, 
                                FinishDate = @FinishDate, 
                                Private = @Private
                             WHERE Id = @Id";

            await _dbAccess.SaveDataAsync(sqlQuery, task);
        }


        public async Task DeleteTaskAsync(int id)
        {
            var sqlQuery = "DELETE FROM [Task] WHERE Id = @Id";

            await _dbAccess.SaveDataAsync(sqlQuery, new { Id = id });
        }

       
    }
}
