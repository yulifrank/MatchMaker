using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaker.Core.Entities
{
<<<<<<< HEAD
    public class Guy : Person
=======
    namespace MatchMaker.Core.Entities
>>>>>>> f814bc982c82016ba8a39fb3a3e241bc2a28d8dd
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

        public Guy(string firstName, string lastName, DateOnly birthday, int opennessLevel, string fatherName, string motherName, float hight, Motza motza, int vaad, string remark = "", string resume = null, string img = null)
            : base(firstName, lastName, birthday, opennessLevel, fatherName, motherName, hight, motza, remark, resume) // קריאה לקונסטרוקטור של Person
        {
            Vaad = vaad;  
        }

        public Guy() { }
    }
