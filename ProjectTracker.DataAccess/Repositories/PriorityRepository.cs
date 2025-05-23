﻿using ProjectTracker.Core.Interfaces.Data;
using ProjectTracker.Core.Interfaces.Repos;
using ProjectTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.DataAccess.Repositories
{
    public class PriorityRepository : IPriorityRepository
    {
        private readonly ISqlDataAccess _dbAccess;
        public PriorityRepository(ISqlDataAccess dbAccess)
        {
            _dbAccess = dbAccess;
        }
        public async Task<IEnumerable<Priority>> GetAllPriorityAsync()
        {
            
            return await _dbAccess.LoadDataAsync<Priority, dynamic>("dbo.GetAllPriorities", new { });
        }

        public Task<Priority> GetPriorityByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
