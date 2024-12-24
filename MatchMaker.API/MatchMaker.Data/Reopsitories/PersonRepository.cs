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
        public async Task<Person> AddAsync(Person person)
        {
            // אל תגדיר את ה-ID כאן - הוא מתמלא אוטומטית
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
        public async Task<Person> UpdateAsync(Person personPostModel)
        {
            var existingPerson = await _context.Persons
                                               .Where(p => p.Id == personPostModel.Id)
                                               .FirstOrDefaultAsync();
            if (existingPerson != null)
            {
                // עדכון כל השדות
                existingPerson.FirstName = personPostModel.FirstName;
                existingPerson.LastName = personPostModel.LastName;
                existingPerson.Birthday = personPostModel.Birthday;
                existingPerson.OpennessLevel = personPostModel.OpennessLevel;
                existingPerson.FatherName = personPostModel.FatherName;
                existingPerson.MotherName = personPostModel.MotherName;
                existingPerson.Height = personPostModel.Height;
                existingPerson.Motza = personPostModel.Motza;
                existingPerson.Remark = personPostModel.Remark;
                existingPerson.Img = personPostModel.Img;
                existingPerson.Resume = personPostModel.Resume;

                await _context.SaveChangesAsync(); // שמירה של השינויים
                return existingPerson;
            }

            return null;  // אם לא נמצא אדם לעדכון
        }

    }
}
