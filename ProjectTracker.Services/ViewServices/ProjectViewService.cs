using ProjectTracker.Core.Interfaces.Repos;
using ProjectTracker.Core.Interfaces.Services;
using ProjectTracker.Core.Models;
using ProjectTracker.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Services.ViewServices
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

        //do i still even need this?? delete later or fill in if there is reason to have it
        public async Task<IEnumerable<Project>> GetAllProjectsAsync()
        {
            var projects = await _projectRepo.GetAllProjectsAsync();

            return projects;
        }



        public async Task<IEnumerable<ProjectListViewModel>> GetAllProjectsFilteredAsync(int? statusId, int? priorityId, string sortBy, string sortOrder)
        {
            var projects = await _projectRepo.GetProjectsFilterableAsync(statusId, priorityId, sortBy, sortOrder);
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

        public async Task<IEnumerable<Status>> GetStatusesAsync()
        {
            return await _statusRepo.GetAllStatusAsync();
        }
        public async Task<IEnumerable<Priority>> GetPrioritiesAsync()
        {
            return await _priorityRepo.GetAllPriorityAsync();
        }

        public async Task<Project> GetProjectByIdAsync(int id)
        {
            return await _projectRepo.GetProjectByIdAsync(id);
        }

        public async Task UpdateProjectAsync(Project project)
        {
            await _projectRepo.UpdateProjectAsync(project);
        }

        public async Task DeleteProjectAndRelatedTasksAsync(int id)
        {
            await _projectRepo.DeleteProjectAsync(id);
        }

        public async Task AddProjectAsync(Project project)
        {
            await _projectRepo.AddProjectAsync(project);
        }
    }
}
