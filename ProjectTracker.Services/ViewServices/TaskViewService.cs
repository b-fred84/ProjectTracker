using Microsoft.Data.SqlClient;
using ProjectTracker.Core.Interfaces.Repos;
using ProjectTracker.Core.Interfaces.Services;
using ProjectTracker.Core.Models;
using ProjectTracker.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Services.ViewServices
{
    public class TaskViewService : ITaskViewService
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


        public async Task<IEnumerable<TaskListViewModel>> GetAllTasksFilteredAsync(int? projectId, int? statusId, int? priorityId, string sortBy, string sortOrder)
        {
            var tasks = await _taskRepo.GetTasksFilterableAsync(projectId, statusId, priorityId, sortBy, sortOrder);
            var projects = await _projectRepo.GetAllProjectsAsync();
            var statuses = await _statusRepo.GetAllStatusAsync();
            var priorities = await _priorityRepo.GetAllPriorityAsync();

            Dictionary<int, string> projectDict = projects.ToDictionary(p => p.Id, p => p.Name);
            Dictionary<int, string> statusDict = statuses.ToDictionary(s => s.Id, s => s.Name);
            Dictionary<int, string> priorityDict = priorities.ToDictionary(p => p.Id, p => p.Name);

            List<TaskListViewModel> taskListVM = new List<TaskListViewModel>();

            foreach (var task in tasks)
            {
                TaskListViewModel taskVM = new TaskListViewModel()
                {
                    Id = task.Id,
                    Name = task.Name,
                    ProjectName = projectDict[task.ProjectId],
                    Status = statusDict[task.StatusId],
                    Priority = priorityDict[task.PriorityId],
                    StartDate = task.StartDate,
                    FinishDate = task.FinishDate
                };
                taskListVM.Add(taskVM);
            }

            return taskListVM;
        }

        public async Task<TaskModel> GetTaskByIdAsync(int id)
        {
            return await _taskRepo.GetTaskByIdAsync(id);
        }

        public async Task UpdateTaskAsync(TaskModel task)
        {
            await _taskRepo.UpdateTaskAsync(task);
        }


        public async Task DeleteTaskAsync(int id)
        {
            await _taskRepo.DeleteTaskAsync(id);
        }

        public async Task AddTaskAsync(TaskModel task)
        {
            await _taskRepo.AddTaskAsync(task);
        }



        //dont need these?  doing it from projectViewService
        //(currently have to inject project anyuway so easier to do all from projectViewService)
        //if project grows maybe useful to add these in here too but for now not much point

        public Task<IEnumerable<Priority>> GetPrioritiesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Status>> GetStatusesAsync()
        {
            throw new NotImplementedException();
        }

    }
}





