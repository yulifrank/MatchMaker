using MatchMaker.Core.Entities;
using MatchMaker.Core.Entities.MatchMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaker.Core.Services
{
    internal interface IGuyService
    {
        Task<List<Guy>> GetListAsync();
        Task<Guy> GetByIdAsync(int id);
        Guy Add(Guy entity);
        Guy Update(Guy guy);
        void Delete(Guy guy);
    }
}
