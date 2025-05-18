using ProjectTracker.Core.Interfaces.Repos;
using ProjectTracker.Core.Interfaces.Services;
using ProjectTracker.Core.Models;
using ProjectTracker.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Services
{
    public class IdeaViewService : IIdeaViewService
    {
        private readonly IIdeaRepository _ideaRepo;

        public IdeaViewService(IIdeaRepository ideaRepo)
        {
            _ideaRepo = ideaRepo;
        }
        public async Task<IEnumerable<IdeaListViewModel>> GetAllIdeasAsync(string sortBy, string sortOrder)
        {
            var ideas = await _ideaRepo.GetAllIdeasAsync(sortBy, sortOrder);

            List<IdeaListViewModel> IdeasListVM = new List<IdeaListViewModel>();

            foreach (var idea in ideas)
            {
                IdeaListViewModel IdeaVM = new IdeaListViewModel
                {
                    Id = idea.Id,
                    Name = idea.Name
                };
                IdeasListVM.Add(IdeaVM);
            }

            return IdeasListVM;
        
        }

        public async Task<ProjectIdea> GetIdeaAsync(int id)
        {
            return await _ideaRepo.GetIdeaByIdAsync(id); 
        }

        public async Task UpdateIdeaAsync(ProjectIdea idea)
        {
            await _ideaRepo.UpdateIdeaAsync(idea);
        }

        public async Task DeleteIdeaAsync(int id)
        {
            await _ideaRepo.DeleteIdeaAsync(id);
        }
    }
}
