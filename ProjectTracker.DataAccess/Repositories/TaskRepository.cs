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

        public async Task<IEnumerable<TaskModel>> GetAllTasksAsync()
        {
            var sqlQuery = "SELECT * FROM [Task]";

            return await _dbAccess.LoadDataAsync<TaskModel, dynamic>(sqlQuery, new { });
        }

        public async Task<TaskModel> GetTaskByIdAsync(int id)
        {
            var sqlQuery = "SELECT * FROM [Task] WHERE Id = @Id";

            var results = await _dbAccess.LoadDataAsync<TaskModel, dynamic> (sqlQuery, new { Id = id });

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
