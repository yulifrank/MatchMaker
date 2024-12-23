using MatchMaker.Core.Entities;
using MatchMaker.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace MatchMaker.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DataContext _context;

        public PersonRepository(DataContext context)
        {
            _context = context;
        }

        // הוספת אדם
        public async Task<Person> AddAsync(Person person) {

            await _context.Persons.AddAsync(person);
            await _context.SaveChangesAsync();

            return person;
        }

        // מחיקת אדם
        public async Task DeleteAsync(Person person)
        {
            var personToDelete = await _context.Persons
                                                .Where(p => p.Id == person.Id)
                                                .FirstOrDefaultAsync();

            if (personToDelete != null)
            {
                _context.Persons.Remove(personToDelete); // הסרה מהקשר
                await _context.SaveChangesAsync(); // שמירה של השינויים
            }
        }

        // קבלת אדם לפי ID
        public async Task<Person?> GetByIdAsync(int id)
        {
            return await _context.Persons
                                 .Where(p => p.Id == id)
                                 .FirstOrDefaultAsync(); // מציאת אדם לפי ID
        }

        // קבלת רשימה של אנשים
        public async Task<List<Person>> GetListAsync()
        {
            return await _context.Persons.ToListAsync(); // קבלת רשימה אסינכרונית של כל האנשים
        }

        // עדכון אדם
        public async Task<Person> UpdateAsync(Person person)
        {
            var existingPerson = await _context.Persons
                                               .Where(p => p.Id == person.Id)
                                               .FirstOrDefaultAsync();

            if (existingPerson != null)
            {
                existingPerson.Name = person.Name;  // עדכון שדות לדוגמה

                await _context.SaveChangesAsync(); // שמירה של השינויים
                return existingPerson;
            }

            return null;  // אם לא נמצא אדם לעדכון
        }
    }
}
