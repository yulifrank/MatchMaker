using MatchMaker.Core.Entities;
using MatchMaker.Core.Repositories;
using MatchMaker.Core.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatchMaker.Service.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _repository;

        public PersonService(IPersonRepository repository)
        {
            _repository = repository;
        }

        public async Task<Person> Add(Person entity)
        {
            return await _repository.AddAsync(entity);
        }

        public async Task Delete(Person person)
        {
            await _repository.DeleteAsync(person);
        }

        public async Task<Person?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<List<Person>> GetListAsync()
        {
            return await _repository.GetListAsync();
        }

        public async Task<Person> Update(Person person)
        {
            return await _repository.UpdateAsync(person);
        }
    }
}
