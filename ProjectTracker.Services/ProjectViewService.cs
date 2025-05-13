using ProjectTracker.Core.Interfaces.Repos;
using ProjectTracker.Core.Interfaces.Services;
using ProjectTracker.Core.Models;
using ProjectTracker.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Services
{
    public class ProjectViewService : IProjectViewService
    {
        private readonly IProjectRepository _projectRepo;
        private readonly IStatusRepository _statusRepo;
        private readonly IPriorityRepository _priorityRepo;

        public ProjectViewService(IProjectRepository projectRepo,
                                  IStatusRepository statusRepo,
                                  IPriorityRepository priorityRepo)
        {
            _projectRepo = projectRepo;
            _statusRepo = statusRepo;
            _priorityRepo = priorityRepo;

        }

        public async Task<IEnumerable<ProjectListViewModel>> GetAllProjectsAsync()
        {
            var projects = await _projectRepo.GetAllProjectsAsync();
            var statuses = await _statusRepo.GetAllStatusAsync();
            var priorities = await _priorityRepo.GetAllPriorityAsync();

            Dictionary<int, string> statusDictionary = statuses.ToDictionary(s => s.Id, s => s.Name);
            Dictionary<int, string> priorityDictionary = priorities.ToDictionary(p => p.Id, p => p.Name);

            List<ProjectListViewModel> projectListVM = new List<ProjectListViewModel>();

            foreach (Project project in projects)
            {
                ProjectListViewModel projectVM = new ProjectListViewModel
                {
                    Id = project.Id,
                    Name = project.Name,
                    Status = statusDictionary.ContainsKey(project.StatusId) ? statusDictionary[project.StatusId] : "Status not found",
                    Priority = priorityDictionary.ContainsKey(project.PriorityId) ? priorityDictionary[project.PriorityId] : "Priority not found",
                    StartDate = project.StartDate,
                    FinishDate = project.FinishDate,
                    HasTasks = project.HasTasks
                };
                projectListVM.Add(projectVM);
            }

            return projectListVM;
        }
    }
}
