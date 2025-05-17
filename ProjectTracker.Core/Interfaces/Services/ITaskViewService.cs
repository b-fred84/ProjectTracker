using ProjectTracker.Core.Models;
using ProjectTracker.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Core.Interfaces.Services
{
    public interface ITaskViewService
    {
        Task<IEnumerable<TaskListViewModel>> GetAllTasksFilteredAsync(int? projectId, int? statusId, int? priorityId, string sortBy, string sortOrder);
        Task<IEnumerable<Status>> GetStatusesAsync();
        Task<IEnumerable<Priority>> GetPrioritiesAsync();
    }
}
