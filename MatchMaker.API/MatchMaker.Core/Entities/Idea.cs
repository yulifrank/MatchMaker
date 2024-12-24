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
        public string StatusDescription { get; set; }

        static int idIdea = 0;
        public Idea(Guy guy,Girl girl,string statusDescription)
        {
            Id = idIdea++;
            Guy = guy;
            Girl = girl;
            StatusDescription = statusDescription;


        }
    }
}
