using ProjectTracker.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Core.Interfaces.Services
{
    public interface IProjectViewService
    {
        Task<IEnumerable<ProjectListViewModel>> GetAllProjectsAsync();

    }
}
