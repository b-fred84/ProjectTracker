using ProjectTracker.Core.Interfaces.Services;
using ProjectTracker.Core.Models;
using ProjectTracker.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Services
{
    public class IdeaViewService : IIdeaViewService
    {
        public async Task<IEnumerable<IdeaListViewModel>> GetAllIdeasAsync()
        {
            //var sqlQuery = "SELECT * FROM ProjectIdea";

            //return await _

                 throw new NotImplementedException();
        }

        public Task<ProjectIdea> GetIdeaAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
