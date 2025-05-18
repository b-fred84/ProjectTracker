using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTracker.Core.Models;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using Microsoft.Extensions.Configuration;
using ProjectTracker.Core.Interfaces.Repos;
using ProjectTracker.Core.Interfaces.Data;
using System.Threading.Tasks.Dataflow;




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
        return await _dbAccess.LoadDataAsync<Project, dynamic>("dbo.GetAllProjects", new {});
    }

    public async Task<IEnumerable<Project>> GetProjectsFilterableAsync(
        int? statusId, int? priorityId, string sortBy, string sortOrder)
    {
        return await _dbAccess.LoadDataAsync<Project, dynamic>(
            "dbo.GetAllProjects",
            new { StatusId = statusId, PriorityId = priorityId, SortBy = sortBy, SortOrder = sortOrder });
    }

    public async Task<Project> GetProjectByIdAsync(int id)
    {
        var results = await _dbAccess.LoadDataAsync<Project, dynamic> ("dbo.GetProjectById", new { Id = id });

        return results.FirstOrDefault();
    }


    public async Task UpdateProjectAsync(Project project)
    {
        var sqlQuery = @"UPDATE Project 
                         SET 
                            Name = @Name, 
                            Description = @Description, 
                            StatusId = @StatusId, 
                            PriorityId = @PriorityId, 
                            StartDate = @StartDate, 
                            FinishDate = @FinishDate, 
                            Private = @Private
                         WHERE Id = @Id";

        await _dbAccess.SaveDataAsync(sqlQuery, project);
    }

    public async Task DeleteProjectAsync(int id)
    {
        var sqlQuery = "DELETE FROM Project WHERE Id = @Id";

        await _dbAccess.SaveDataAsync(sqlQuery, new { Id = id });
    }

}
