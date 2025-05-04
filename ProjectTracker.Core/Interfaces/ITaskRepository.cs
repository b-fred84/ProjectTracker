using ProjectTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Core.Interfaces
{
    public interface ITaskRepository
    {
        Task<IEnumerable<TaskModel>> GetAllTasksAsync();
        Task<TaskModel> GetTaskById(int Id);
        Task<IEnumerable<Priority>> GetAllPriorityAsync();
        Task<IEnumerable<Status>> GetAllStatusAsync();
        Task DeletAsync(int Id);
        Task AddAsync(TaskModel taskk);
        Task UpdateAsync(TaskModel taskk);
    }
}
