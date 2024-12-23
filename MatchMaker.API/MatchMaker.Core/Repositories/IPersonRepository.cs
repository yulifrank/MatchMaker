using MatchMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaker.Core.Repositories
{
    public interface IPersonRepository
    {
        Task<List<Person>> GetListAsync(); // קבלת רשימה של אנשים
        Task<Person?> GetByIdAsync(int id); // קבלת אדם לפי id
        Task<Person> AddAsync(Person entity); // הוספת אדם
        Task<Person> UpdateAsync(Person person); // עדכון אדם
        Task DeleteAsync(Person person); // מחיקת אדם

    }
}
