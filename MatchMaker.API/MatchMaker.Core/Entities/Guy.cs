using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaker.Core.Entities
{
    public class Guy : Person
    {
        public int Vaad { get; set; }

        public Guy(string firstName, string lastName, DateOnly birthday, int opennessLevel, string fatherName, string motherName, float hight, Motza motza, int vaad, string remark = "", string resume = null, string img = null)
            : base(firstName, lastName, birthday, opennessLevel, fatherName, motherName, hight, motza, remark, resume) // קריאה לקונסטרוקטור של Person
        {
            Vaad = vaad;  
        }

        public Guy() { }
    }
}
