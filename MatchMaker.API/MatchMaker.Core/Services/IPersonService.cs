using MatchMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaker.Core.Services
{
    internal interface IPersonService
    {
        Task<List<Person>> GetListAsync();
        Task<Person?> GetByIdAsync(int id);
        Person Add(Person entity);
        Person Update(Person person);
        void Delete(Person person);
    }
}
