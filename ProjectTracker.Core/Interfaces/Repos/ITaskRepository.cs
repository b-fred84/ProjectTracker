using ProjectTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Core.Interfaces.Repos
{
    public interface ITaskRepository
    {
        Task<IEnumerable<TaskModel>> GetAllTasksAsync();
        Task<IEnumerable<TaskModel>> GetTasksFilterableAsync(int? projectId, int? statusId, int? priorityId, string sortBy, string sortOrder);
        Task<TaskModel> GetTaskByIdAsync(int id);
        Task DeleteTaskAsync(int id);
        Task AddTaskAsync(TaskModel task);
        Task UpdateTaskAsync(TaskModel task);
    }
}
