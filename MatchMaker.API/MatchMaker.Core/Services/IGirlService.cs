using MatchMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaker.Core.Services
{
    internal interface IGirlService
    {
        Task<List<Girl>> GetListAsync();
        Task<Girl?> GetByIdAsync(int id);
        Girl Add(Girl entity);
        Girl Update(Girl girl);
        void Delete(Girl girl);
    }
}
