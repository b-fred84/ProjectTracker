using ProjectTracker.Core.Models;
using ProjectTracker.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Core.Interfaces.Services
{
    public interface IIdeaViewService
    {
        Task<IEnumerable<IdeaListViewModel>> GetAllIdeasAsync(string sortBy, string sortOrder);
        Task<ProjectIdea> GetIdeaAsync(int id);
        Task UpdateIdeaAsync(ProjectIdea idea);
        Task DeleteIdeaAsync(int id);
    }
}
