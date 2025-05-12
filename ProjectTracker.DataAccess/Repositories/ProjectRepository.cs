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

    public async Task<Project> GetProjectByIdAsync(int id)
    {
        var sqlQuery = "SELECT * From Project WHERE Id = @Id";

        var results = await _dbAccess.LoadDataAsync<Project, dynamic> (sqlQuery, new { Id = id });

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
