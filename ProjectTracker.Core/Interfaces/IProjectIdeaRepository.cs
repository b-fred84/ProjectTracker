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
        Task<IEnumerable<ProjectIdea>> GetAllAsync();
        Task<ProjectIdea> GetProjectIdeaByIdAsync(int Id);
        Task AddAsync(ProjectIdea projectIdea);
        Task UpdateAsync(ProjectIdea projectIdea);
        Task DeleteAsync(int Id);

    }
}
