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


        public async Task<IEnumerable<TaskModel>> GetAllAsync()
        {
            var sqlQuery = "SELECT * FROM Task";
            return await _dbConnection.QueryAsync<TaskModel>(sqlQuery);
        }

        public Task<TaskModel> GetTaskById(int Id)
        {
            throw new NotImplementedException();
        }


        public async Task<IEnumerable<Priority>> GetAllPriorityAsync()
        {
            var sqlQuery = "SELECT * FROM Priority";
            return await _dbConnection.QueryAsync<Priority>(sqlQuery);
        }

        public async Task<IEnumerable<Status>> GetAllStatusAsync()
        {
            var sqlQuery = "SELECT * FROM Status";
            return await _dbConnection.QueryAsync<Status>(sqlQuery);
        }

        public async Task<IEnumerable<Project>> GetAllProjectsAsync()
        {
            var sqlQuery = "SELECT Id, Name FROM Project";
            return await _dbConnection.QueryAsync<Project>(sqlQuery);
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
