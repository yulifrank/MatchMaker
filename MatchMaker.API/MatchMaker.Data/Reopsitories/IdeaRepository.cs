using MatchMaker.Core.Entities;
using MatchMaker.Core.Entities.MatchMaker.Core.Entities;
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

        // הוספנו Include כדי להחזיר את הבחור והבחורה
        public async Task<Idea?> GetByIdAsync(int id)
        {
            return await _context.Ideas
                                 .Include(i => i.Guy)  // טוען את ה-Guy הקשורים ל-Idea
                                 .Include(i => i.Girl) // טוען את ה-Girl הקשורים ל-Idea
                                 .FirstOrDefaultAsync(i => i.Id == id);
        }

        // הוספנו Include גם כאן
        public async Task<List<Idea>> GetListAsync()
        {
            return await _context.Ideas.Include(i => i.Guy)  // טוען את ה-Guy הקשורים ל-Idea
                                 .Include(i => i.Girl).ToListAsync();
                             
        }

        public async Task<Idea> AddAsync(Idea idea)
        {
            if (idea == null)
            {
                throw new ArgumentNullException(nameof(idea));
            }

            // בדוק אם ה-Id של Guy קיים בטבלת האנשים
            var guyExists = await _context.Persons.AnyAsync(p => p.Id == idea.GuyId);
            if (!guyExists)
            {
                throw new Exception($"Guy with ID {idea.GuyId} does not exist.");
            }

            // בדוק אם ה-Id של Girl קיים בטבלת האנשים
            var girlExists = await _context.Persons.AnyAsync(p => p.Id == idea.GirlId);
            if (!girlExists)
            {
                throw new Exception($"Girl with ID {idea.GirlId} does not exist.");
            }

            // טוען את ה- Guy וה- Girl מתוך המסד נתונים
            var guy = await _context.Persons.FirstOrDefaultAsync(p => p.Id == idea.GuyId);  // טוען את ה-Guy
            var girl = await _context.Persons.FirstOrDefaultAsync(p => p.Id == idea.GirlId); // טוען את ה-Girl

            // אם אחד מהם לא נמצא, יש להחזיר שגיאה
            if (guy == null || girl == null)
            {
                throw new Exception("Guy or Girl not found.");
            }

            // עדכון שדות ה- Guy וה- Girl ב- Idea
            idea.Guy = (Guy)guy;
            idea.Girl = (Girl)girl;

            // אם כל המפתחות קיימים, הוסף את ה- Idea למסד הנתונים
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
