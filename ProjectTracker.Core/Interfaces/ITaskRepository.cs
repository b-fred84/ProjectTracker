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
        Task<IEnumerable<TaskModel>> GetAllAsync();
        Task<TaskModel> GetTaskById(int Id);
        Task<IEnumerable<Priority>> GetAllPriorityAsync();
        Task<IEnumerable<Status>> GetAllStatusAsync();
        Task<IEnumerable<Project>> GetAllProjectsAsync();
        Task DeletAsync(int Id);
        Task AddAsync(TaskModel task);
        Task UpdateAsync(TaskModel task);
    }
}
