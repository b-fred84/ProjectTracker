using ProjectTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Core.Interfaces.Repos
{
    public interface IIdeaRepository
    {
        Task<IEnumerable<ProjectIdea>> GetAllIdeasAsync();
        Task<ProjectIdea> GetIdeaByIdAsync(int id);
        Task AddIdeaAsync(ProjectIdea projectIdea);
        Task UpdateIdeaAsync(ProjectIdea projectIdea);
        Task DeleteIdeaAsync(int id);

    }
}
