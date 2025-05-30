

namespace ProjectTracker.Core.Interfaces.Services
{
    public interface IExportService
    {
        Task ExportProjectsWithTasksToFileAsync(string filePath);

        Task ExportAllToFileAsync(string filePath);
    }
}