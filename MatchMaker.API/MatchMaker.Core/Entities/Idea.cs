using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaker.Core.Entities
{
    internal class Idea
    {
        public int Id { get; set; }
        public Guy guy { get; set; }
        public Girl girl { get; set; }
        public string status_description { get; set; }
    }
}
