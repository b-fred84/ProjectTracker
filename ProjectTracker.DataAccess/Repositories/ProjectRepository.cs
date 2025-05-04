using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTracker.Core.Models;
using ProjectTracker.Core.Interfaces;
using System.Data;
using Dapper;



namespace ProjectTracker.DataAccess.Repositories;

public class ProjectRepository : IProjectRepository
{

    private readonly IDbConnection _dbConnection;

    public ProjectRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

   

    public async Task AddAsync(Project project)
    {
        var sqlQuery = @"INSERT INTO Project (Name, Description, StatusId, PriorityId, StartDate, FinishDate, Private)
                       VALUES (@Name, @Description, @StatusId, @PriorityId, @StartDate, @FinishDate, @Private)";

        await  _dbConnection.ExecuteAsync(sqlQuery, project);
    }

  

    public async Task<IEnumerable<Project>> GetAllAsync()
    {
        var sqlQuery = "SELECT * FROM Project";

        return await _dbConnection.QueryAsync<Project>(sqlQuery);
    }

    public Task<Project> GetProjectByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Priority>> GetAllPriorityAsync()
    {
        var sqlQuery = "SELECT * FROM Priority";
        return await _dbConnection.QueryAsync<Priority>(sqlQuery);
    }

    public async Task<IEnumerable<Status>> GetAllStatusAsync()
    {
        var sqlQuery = "SELECT * FROM Status";
        return await _dbConnection.QueryAsync<Status>(sqlQuery);
    }



    public Task UpdateAsync(Project project)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

 
}
