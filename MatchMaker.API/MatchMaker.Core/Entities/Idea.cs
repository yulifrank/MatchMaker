using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaker.Core.Entities
{
    public class Idea
    {
        public int Id { get; set; }
        public Guy Guy { get; set; }
        public Girl Girl { get; set; }
        public string Status_description { get; set; }
    }
}
