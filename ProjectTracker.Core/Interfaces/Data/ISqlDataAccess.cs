namespace ProjectTracker.Core.Interfaces.Data
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> LoadDataAsync<T, U>(string sqlQuery, U parameters, string connectionString = "ProjectTrackerConnectionString");
        Task SaveDataAsync<T>(string sqlQuery, T parameters, string connectionString = "ProjectTrackerConnectionString");
    }
}