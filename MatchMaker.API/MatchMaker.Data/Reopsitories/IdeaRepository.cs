
using MatchMaker.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaker.Data.Reopsitories
{
    public class IdeaRepository : IIdeaRepository

    {
        private readonly DataContext _context;
        public IdeaRepository( DataContext context)
        {
            _context = context;
        }

        Idea IIdeaRepository.Add(Idea idea)
        {
            throw new NotImplementedException();
        }

        void IIdeaRepository.Delete(Idea idea)
        {
            throw new NotImplementedException();
        }

        Task<Idea?> IIdeaRepository.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Idea>> IIdeaRepository.GetListAsync()
        {
            throw new NotImplementedException();
        }

        Idea IIdeaRepository.Update(Idea idea)
        {
            throw new NotImplementedException();
        }
    }
}
