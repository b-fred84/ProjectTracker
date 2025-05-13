using ProjectTracker.Core.Interfaces.Repos;
using ProjectTracker.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Services
{
    public class TaskViewService
    {
        private readonly ITaskRepository _taskRepo;
        private readonly IProjectRepository _projectRepo;
        private readonly IStatusRepository _statusRepo;
        private readonly IPriorityRepository _priorityRepo;

        public TaskViewService(ITaskRepository taskRepo, IProjectRepository projectRepo, IStatusRepository statusRepo, IPriorityRepository priorityRepo)
        {
            _taskRepo = taskRepo;
            _projectRepo = projectRepo;
            _statusRepo = statusRepo;
            _priorityRepo = priorityRepo;
        }

        //public async Task<IEnumerable<TaskListViewModel>> GetAllTasksAsync()
        //{
           
        //}
    }
}
