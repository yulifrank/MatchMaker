using MatchMaker.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatchMaker.Core.Services
{
    public interface IIdeaService
    {
        Task<List<Idea>> GetListAsync();         // פעולה אסינכרונית לקבלת רשימת רעיונות
        Task<Idea?> GetByIdAsync(int id);        // פעולה אסינכרונית לקבלת רעיון לפי מזהה
        Task<Idea> AddAsync(Idea entity);        // פעולה אסינכרונית להוספת רעיון
        Task<Idea> UpdateAsync(Idea idea);       // פעולה אסינכרונית לעדכון רעיון
        Task DeleteAsync(Idea idea);             // פעולה אסינכרונית למחיקת רעיון
    }
}
