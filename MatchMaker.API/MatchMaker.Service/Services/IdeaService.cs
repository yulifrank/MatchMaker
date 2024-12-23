using MatchMaker.Core.Entities;
using MatchMaker.Core.Repositories;
using MatchMaker.Core.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatchMaker.Service.Services
{
    public class IdeaService : IIdeaService
    {
        private readonly IIdeaRepository _repository;

        public IdeaService(IIdeaRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<Idea> AddAsync(Idea entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            return await _repository.AddAsync(entity);
        }

        public async Task DeleteAsync(Idea idea)
        {
            if (idea == null)
            {
                throw new ArgumentNullException(nameof(idea));
            }

            await _repository.DeleteAsync(idea);
        }

        public async Task<Idea?> GetByIdAsync(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID must be greater than zero.", nameof(id));
            }

            return await _repository.GetByIdAsync(id);
        }

        public async Task<List<Idea>> GetListAsync()
        {
            return await _repository.GetListAsync();
        }

        public async Task<Idea> UpdateAsync(Idea idea)
        {
            if (idea == null)
            {
                throw new ArgumentNullException(nameof(idea));
            }

            return await _repository.UpdateAsync(idea);
        }
    }
}
