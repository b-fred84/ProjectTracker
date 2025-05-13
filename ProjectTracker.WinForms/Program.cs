using System.ServiceProcess;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using ProjectTracker.DataAccess.Repositories;
using ProjectTracker.DataAccess.SqlDataAccessWrappers;
using Microsoft.Data.SqlClient;
using System.Data;
using ProjectTracker.WinForms.Forms;
using ProjectTracker.Core.Interfaces.Repos;
using ProjectTracker.Core.Interfaces.Data;
using ProjectTracker.Core.Interfaces.Services;
using ProjectTracker.Services;

namespace ProjectTracker.WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            try
            {
                ApplicationConfiguration.Initialize();


                //handles loading config from appsettings.json
                var config = new ConfigurationBuilder()
                    .SetBasePath(AppContext.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();


                //string connectionString = config.GetConnectionString("ProjectTrackerConnectionString");

                //adds required services
                var services = new ServiceCollection()
                    //.AddScoped<IDbConnection>(_ => new SqlConnection(connectionString))
                    .AddSingleton<IConfiguration>(config)

                    .AddScoped<ISqlDataAccess, SqlDataAccess>()

                    .AddScoped<IProjectRepository, ProjectRepository>()
                    .AddScoped<ITaskRepository, TaskRepository>()
                    .AddScoped<IIdeaRepository, ProjectIdeaRepository>()
                    .AddScoped<IPriorityRepository, PriorityRepository>()
                    .AddScoped<IStatusRepository, StatusRepository>()

                    .AddScoped<IProjectViewService, ProjectViewService>()

                    .AddScoped<AddProjectForm>()
                    .AddScoped<AddTaskForm>()
                    .AddScoped<AddProjectIdeaForm>()
                    .AddScoped<ViewForm>()
                    .AddScoped<MainForm>()

                    .BuildServiceProvider();


                var mainForm = services.GetRequiredService<MainForm>();
                Application.Run(mainForm);



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

         
        }
    }
}