using ProjectTracker.Core.Interfaces.Repos;
using ProjectTracker.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Services.ExportServices
{
    public class ExportService : IExportService
    {
        private readonly IProjectRepository _projectRepo;
        private readonly ITaskRepository _taskRepo;
        private readonly IIdeaRepository _ideaRepo;

        public ExportService(IProjectRepository projectRepo, ITaskRepository taskRepo, IIdeaRepository ideaRepo)
        {
            _projectRepo = projectRepo;
            _taskRepo = taskRepo;
            _ideaRepo = ideaRepo;
        }

        public async Task ExportProjectsWithTasksToFileAsync(string filePath)
        {
            var projects = await _projectRepo.GetAllProjectsAsync();
            var tasks = await _taskRepo.GetAllTasksAsync();

            StringBuilder output = new StringBuilder();

            foreach (var project in projects.Where(p => !p.Private))
            {
                output.AppendLine($"Project: {project.Name}");
                output.AppendLine();
                output.AppendLine($"Description: {project.Description}");
                output.AppendLine();

                if (project.HasTasks)
                {
                    foreach (var task in tasks.Where(t => !t.Private && t.ProjectId == project.Id))
                    {
                        output.AppendLine();
                        output.AppendLine($"\t Task: {task.Name}");
                        output.AppendLine();
                        output.AppendLine($"\t Details: {task.Details}");
                        output.AppendLine();
                    }
                }

                
                output.AppendLine(new string('-', 50));
                output.AppendLine();
            }

            await File.WriteAllTextAsync(filePath, output.ToString());

        }

        public async Task ExportAllToFileAsync(string filePath)
        {
            var projects = await _projectRepo.GetAllProjectsAsync();
            var tasks = await _taskRepo.GetAllTasksAsync();
            var ideas = await _ideaRepo.GetAllIdeasAsync("Name", "asc");

            StringBuilder output = new StringBuilder();

            output.AppendLine("=== PROJECTS ===");
            output.AppendLine();
            output.AppendLine();

            foreach (var project in projects)
            {
                output.AppendLine($"Project: {project.Name}");
                output.AppendLine();
                output.AppendLine($"Description: {project.Description}");
                output.AppendLine();

                if (project.HasTasks)
                {
                    foreach (var task in tasks.Where(t => t.ProjectId == project.Id))
                    {
                        output.AppendLine();
                        output.AppendLine($"\t Task: {task.Name}");
                        output.AppendLine();
                        output.AppendLine($"\t Details: {task.Details}");
                        output.AppendLine();
                    }
                }
                
                output.AppendLine(new string('-', 50));
                output.AppendLine();
            }

            output.AppendLine("=== PROJECT IDEAS ===");
            output.AppendLine();
            output.AppendLine();

            foreach(var idea in ideas)
            {
                output.AppendLine($"Project Idea: {idea.Name}");
                output.AppendLine();
                output.AppendLine($"Description: {idea.Description}");
                output.AppendLine();
                output.AppendLine($"Notes: {idea.Notes}");
                output.AppendLine();
                output.AppendLine(new string('-', 50));
                output.AppendLine();
            }

            await File.WriteAllTextAsync(filePath, output.ToString());

        }
    }
}
