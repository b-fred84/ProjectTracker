using ProjectTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Core.Interfaces.Repos;

public interface IProjectRepository
{
    Task<IEnumerable<Project>> GetAllProjectsAsync();
    Task<IEnumerable<Project>> GetProjectsFilterableAsync(int? statusId, int? priorityId, string sortBy, string sortOrder);
    Task<Project> GetProjectByIdAsync(int id);
    Task DeleteProjectAsync(int id);
    Task AddProjectAsync(Project project);
    Task UpdateProjectAsync(Project project);





}
