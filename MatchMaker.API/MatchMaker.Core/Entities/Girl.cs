using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaker.Core.Entities
{


    public class Girl : Person
    {
        public string Subject { get; set; }
        public int Yearbook { get; set; }

        public Girl(string firstName, string lastName, DateOnly birthday, int opennessLevel, string fatherName, string motherName, float hight, Motza motza, string subject, int yearbook, string remark = "", string resume = null, string img = null)
    : base(firstName, lastName, birthday, opennessLevel, fatherName, motherName, hight, motza, remark, resume) // קריאה לקונסטרוקטור של Person
        {
            Subject = subject;
            Yearbook = yearbook;

        }

        public Girl()
        {

        }
    }
}