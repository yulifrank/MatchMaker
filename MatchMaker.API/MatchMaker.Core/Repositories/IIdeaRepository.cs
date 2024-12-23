using MatchMaker.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatchMaker.Core.Repositories
{
    public interface IIdeaRepository
    {
        Task<List<Idea>> GetListAsync();        
        Task<Idea?> GetByIdAsync(int id);       
        Task<Idea> AddAsync(Idea idea);         
        Task<Idea> UpdateAsync(Idea idea);      
        Task DeleteAsync(Idea idea);            
    }
}
