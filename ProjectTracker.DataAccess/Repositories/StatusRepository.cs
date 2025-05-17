using ProjectTracker.Core.Interfaces.Data;
using ProjectTracker.Core.Interfaces.Repos;
using ProjectTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.DataAccess.Repositories
{
    public class StatusRepository : IStatusRepository
    {
        private readonly ISqlDataAccess _dbAccess;

        public StatusRepository(ISqlDataAccess dbAccess)
        {
            _dbAccess = dbAccess;
        }

        public async Task<IEnumerable<Status>> GetAllStatusAsync()
        {
            
            return await _dbAccess.LoadDataAsync<Status, dynamic>("dbo.GetAllStatuses", new {});
        }

        public async Task<Status> GetStatusByIdAsync(int id)
        {
            var sql = "SELECT * FROM [Status] WHERE Id = @Id";

            var results = await _dbAccess.LoadDataAsync<Status, dynamic>(sql, new {Id = id});
            return results.FirstOrDefault();
        }
    }
}
