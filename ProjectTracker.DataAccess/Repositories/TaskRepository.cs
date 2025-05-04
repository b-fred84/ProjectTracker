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

        private readonly IDbConnection _dbConnection;

        public TaskRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task AddAsync(TaskModel taskk)
        {
            var sqlQuery = @"INSERT INTO Task (ProjectId, Name, Details, StatusId, PriorityId, StartDate, FinishDate, Private)
                           VALUES (@ProjectId, @Name, @Details, @StatusId, @PriorityId, @StartDate, @FinishDate, @Private)";

            await _dbConnection.ExecuteAsync(sqlQuery, taskk);
        }


        public Task<IEnumerable<TaskModel>> GetAllTasksAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TaskModel> GetTaskById(int Id)
        {
            throw new NotImplementedException();
        }


        public Task<IEnumerable<Priority>> GetAllPriorityAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Status>> GetAllStatusAsync()
        {
            throw new NotImplementedException();
        }

      
        public Task UpdateAsync(TaskModel taskk)
        {
            throw new NotImplementedException();
        }

        public Task DeletAsync(int Id)
        {
            throw new NotImplementedException();
        }

    }
}
