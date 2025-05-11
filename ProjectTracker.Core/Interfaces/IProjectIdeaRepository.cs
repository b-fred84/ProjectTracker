using ProjectTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Core.Interfaces
{
    public interface IProjectIdeaRepository
    {
        Task<IEnumerable<ProjectIdea>> GetAllIdeasAsync();
        Task<ProjectIdea> GetIdeaByIdAsync(int Id);
        Task AddIdeaAsync(ProjectIdea projectIdea);
        Task UpdateIdeaAsync(ProjectIdea projectIdea);
        Task DeleteIdeaAsync(int Id);

    }
}
