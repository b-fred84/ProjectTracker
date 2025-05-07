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
    public class ProjectIdeaRepository : IProjectIdeaRepository
    {

        private readonly IDbConnection _dbConnection;

        public ProjectIdeaRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task AddAsync(ProjectIdea projectIdea)
        {
            var sqlQuery = @"INSERT INTO ProjectIdea (Name, Description, Notes)
                           VALUES(@Name, @Description, @Notes)";

            await _dbConnection.ExecuteAsync(sqlQuery, projectIdea);
        }

        public Task DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProjectIdea>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProjectIdea> GetProjectIdeaByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ProjectIdea projectIdea)
        {
            throw new NotImplementedException();
        }
    }
}
