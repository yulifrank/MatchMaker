using MatchMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaker.Core.Services
{
    internal interface IIdeaService
    {
        Task<List<Idea>> GetListAsync();
        Task<Idea?> GetByIdAsync(int id);
        Idea Add(Idea entity);
        Idea Update(Idea idea);
        void Delete(Idea idea);
    }
}
