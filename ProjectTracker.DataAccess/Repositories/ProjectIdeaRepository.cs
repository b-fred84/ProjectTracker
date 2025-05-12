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


        public async Task<IEnumerable<ProjectIdea>> GetAllIdeasAsync()
        {
            var sqlQuery = "SELECT * FROM ProjectIdea";

            return await _dbAccess.LoadDataAsync<ProjectIdea, dynamic>(sqlQuery, new {});
        }

        public async Task<ProjectIdea> GetIdeaByIdAsync(int id)
        {
            var sqlQuery = "SELECT * FROM ProjectIdea WHERE Id = @Id";
            
            var results = await _dbAccess.LoadDataAsync<ProjectIdea, dynamic>(sqlQuery, new {Id = id});

            return results.FirstOrDefault();
        }

        public async Task UpdateIdeaAsync(ProjectIdea projectIdea)
        {
            var sqlQuery = @"UPDATE ProjectIdea 
                             SET
                                Name = @Name,
                                Description = @Description,
                                Notes = @Notes
                             WHERE Id =@Id";

            await _dbAccess.SaveDataAsync(sqlQuery, projectIdea);

        }

        public async Task DeleteIdeaAsync(int id)
        {
            var sqlQuery = "DELETE FROM ProjectIdea WHERE Id = @Id";

            await _dbAccess.SaveDataAsync(sqlQuery, new { Id = id });
        }

    }
}
