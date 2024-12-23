using MatchMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatchMaker.Core.Services
{
    public interface IPersonService
    {
        Task<List<Person>> GetListAsync();        
        Task<Person?> GetByIdAsync(int id);       
        Task<Person> Add(Person entity);          
        Task<Person> Update(Person person);       
        Task Delete(Person person);               
    }
}
