using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTracker.Core.Models;
using ProjectTracker.Core.Interfaces;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using Microsoft.Extensions.Configuration;




namespace ProjectTracker.DataAccess.Repositories;

public class ProjectRepository : IProjectRepository
{
    private readonly ISqlDataAccess _dbAccess;

    public ProjectRepository(ISqlDataAccess dbAccess)
    {
        _dbAccess = dbAccess;
    }

    //public async Task AddAsync(Project project)
    //{

    //    var sqlQuery = @"INSERT INTO Project (Name, Description, StatusId, PriorityId, StartDate, FinishDate, Private)
    //                   VALUES (@Name, @Description, @StatusId, @PriorityId, @StartDate, @FinishDate, @Private)";


    //    await connection.ExecuteAsync(sqlQuery, project);
    //}



    public async Task AddProjectAsync(Project project)
    {
        var sqlQuery = @"INSERT INTO Project (Name, Description, StatusId, PriorityId, StartDate, FinishDate, Private)
                       VALUES (@Name, @Description, @StatusId, @PriorityId, @StartDate, @FinishDate, @Private)";

        await _dbAccess.SaveDataAsync(sqlQuery, project);
    }


    public async Task<IEnumerable<Project>> GetAllProjectsAsync()
    {
        var sqlQuery = "SELECT * FROM Project";

        return await _dbAccess.LoadDataAsync<Project, dynamic>(sqlQuery, new {});
    }

    public Task<Project> GetProjectByIdAsync(int id)
    {
        throw new NotImplementedException();
    }





    public Task DeleteProjectAsync(int id)
    {
        throw new NotImplementedException();
    }

 

    public Task UpdateProjectAsync(Project project)
    {
        throw new NotImplementedException();
    }
}
