using Dapper;
using Microsoft.Data.SqlClient;
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
    public class IdeaRepository : IIdeaRepository
    {

        private readonly ISqlDataAccess _dbAccess;

        public IdeaRepository(ISqlDataAccess dbAccess)
        {
            _dbAccess = dbAccess;
        }

        public async Task AddIdeaAsync(ProjectIdea projectIdea)
        {
            var sqlQuery = @"INSERT INTO ProjectIdea (Name, Description, Notes)
                       VALUES (@Name, @Description, @Notes)";

            await _dbAccess.SaveDataAsync(sqlQuery, projectIdea);
        }


        public async Task<IEnumerable<ProjectIdea>> GetAllIdeasAsync(string sortBy, string sortOrder)
        { 
            return await _dbAccess.LoadDataAsync<ProjectIdea, dynamic>("dbo.GetAllIdeas", new {sortBy, sortOrder});
        }

        public async Task<ProjectIdea> GetIdeaByIdAsync(int id)
        { 
            var results = await _dbAccess.LoadDataAsync<ProjectIdea, dynamic>("dbo.GetIdeaById", new {Id = id});

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
