using MatchMaker.Core.Entities;
using MatchMaker.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchMaker.Data.Repositories
{
    public class IdeaRepository : IIdeaRepository
    {
        private readonly DataContext _context;

        public IdeaRepository(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Idea> AddAsync(Idea idea)
        {
            if (idea == null)
            {
                throw new ArgumentNullException(nameof(idea));
            }

            await _context.Ideas.AddAsync(idea);
            await _context.SaveChangesAsync();
            return idea;
        }

        public async Task DeleteAsync(Idea idea)
        {
            if (idea == null)
            {
                throw new ArgumentNullException(nameof(idea));
            }

            _context.Ideas.Remove(idea);
            await _context.SaveChangesAsync();
        }

        public async Task<Idea?> GetByIdAsync(int id)
        {
            return await _context.Ideas
                                 .FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<List<Idea>> GetListAsync()
        {
            return await _context.Ideas.ToListAsync();
        }

        public async Task<Idea> UpdateAsync(Idea idea)
        {
            if (idea == null)
            {
                throw new ArgumentNullException(nameof(idea));
            }

            _context.Ideas.Update(idea);
            await _context.SaveChangesAsync();
            return idea;
        }
    }
}
