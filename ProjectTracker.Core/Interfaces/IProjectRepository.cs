using ProjectTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Core.Interfaces;

public interface IProjectRepository
{
    Task<IEnumerable<Project>> GetAllAsync();
    Task<Project> GetProjectByIdAsync(int id);
    Task<IEnumerable<Priority>> GetAllPriorityAsync();
    Task<IEnumerable<Status>> GetAllStatusAsync();
    Task DeleteAsync(int id);
    Task AddAsync(Project project);
    Task UpdateAsync(Project project);





}
