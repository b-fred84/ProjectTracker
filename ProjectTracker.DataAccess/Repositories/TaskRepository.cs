using Dapper;
using ProjectTracker.Core.Interfaces;
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
            var sqlQuery = @"INSERT INTO Task (ProjectId, Name, Details, StatusId, PriorityId, StartDate, FinishDate, Private)
                           VALUES (@ProjectId, @Name, @Details, @StatusId, @PriorityId, @StartDate, @FinishDate, @Private)";

            await _dbAccess.SaveDataAsync(sqlQuery, task);
        }

        public Task DeleteTaskAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TaskModel>> GetAllTasksAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TaskModel> GetTaskByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTaskAsync(TaskModel task)
        {
            throw new NotImplementedException();
        }
    }
}
