using MatchMaker.Core.Entities;
using MatchMaker.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaker.Data.Reopsitories
{
    internal class PersonRepository : IPersonRepository
    {
        Person IPersonRepository.Add(Person entity)
        {
            throw new NotImplementedException();
        }

        void IPersonRepository.Delete(Person person)
        {
            throw new NotImplementedException();
        }

        Task<Person?> IPersonRepository.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Person>> IPersonRepository.GetListAsync()
        {
            throw new NotImplementedException();
        }

        Person IPersonRepository.Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
