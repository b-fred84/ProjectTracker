using Dapper;
using Microsoft.Data.SqlClient;
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

        private readonly ISqlDataAccess _dbAccess;

        public ProjectIdeaRepository(ISqlDataAccess dbAccess)
        {
            _dbAccess = dbAccess;
        }

        public async Task AddIdeaAsync(ProjectIdea projectIdea)
        {
            var sqlQuery = @"INSERT INTO ProjectIdea (Name, Description, Notes)
                       VALUES (@Name, @Description, @Notes)";

            await _dbAccess.SaveDataAsync(sqlQuery, projectIdea);
        }

        public Task DeleteIdeaAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProjectIdea>> GetAllIdeasAsync()
        {
            var sqlQuery = "SELECT * FROM ProjectIdea";

            return await _dbAccess.LoadDataAsync<ProjectIdea, dynamic>(sqlQuery, new {});
        }

        public Task<ProjectIdea> GetIdeaByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateIdeaAsync(ProjectIdea projectIdea)
        {
            throw new NotImplementedException();
        }
    }
}
