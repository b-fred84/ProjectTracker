using ProjectTracker.Core.Models;
using ProjectTracker.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Core.Interfaces.Services
{
    public interface IProjectViewService
    {
        Task<IEnumerable<Project>> GetAllProjectsAsync();
        Task<IEnumerable<ProjectListViewModel>> GetAllProjectsFilteredAsync(int? statusId, int? priorityId, string sortBy, string sortOrder);
        Task<Project> GetProjectByIdAsync(int id);
        Task<IEnumerable<Status>> GetStatusesAsync();
        Task<IEnumerable<Priority>> GetPrioritiesAsync();
        Task UpdateProjectAsync(Project project);
        Task DeleteProjectAsync(int id);

    }
}
