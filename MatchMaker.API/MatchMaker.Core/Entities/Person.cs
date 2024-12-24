using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaker.Core.Entities
{
    public enum Motza
    {
        Ashcenaz,
        Sfarad,
        Chasid,
        Teman

    }
    public class Person
    {
        static int IdPerson = 0;
        public int Id { get; set; }
        public string FirstName { get; set; }
<<<<<<< HEAD
        public string LasttName { get; set; }
=======
        public string LastName { get; set; } // תוקן שם השדה מ-LasttName ל-LastName
>>>>>>> f814bc982c82016ba8a39fb3a3e241bc2a28d8dd
        public DateOnly Birthday { get; set; }
        public int OpennessLevel { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
<<<<<<< HEAD
        public float Hight { get; set; }
=======
        public float Height { get; set; }  // תוקן מ-Hight ל-Height
>>>>>>> f814bc982c82016ba8a39fb3a3e241bc2a28d8dd
        public Motza Motza { get; set; }
        public string Remark { get; set; }
        public string Img { get; set; }
        public string Resume { get; set; }

<<<<<<< HEAD
        // קונסטרוקטור של Person
        public Person(string firstName, string lastName, DateOnly birthday, int opennessLevel, string fatherName, string motherName, float hight, Motza motza, string remark = "", string resume = null, string img = null)
        {
            Id=IdPerson++;
            FirstName = firstName;
            LasttName = lastName;
=======
        public Person(string firstName, string lastName, DateOnly birthday, int opennessLevel, string fatherName, string motherName, float height, Motza motza, string remark = "", string resume = null, string img = null)
        {
            Id = IdPerson++;
            FirstName = firstName;
            LastName = lastName;
>>>>>>> f814bc982c82016ba8a39fb3a3e241bc2a28d8dd
            Birthday = birthday;
            OpennessLevel = opennessLevel;
            FatherName = fatherName;
            MotherName = motherName;
<<<<<<< HEAD
            Hight = hight;
=======
            Height = height;
>>>>>>> f814bc982c82016ba8a39fb3a3e241bc2a28d8dd
            Motza = motza;
            Remark = remark;
            Img = img;
            Resume = resume;
        }

<<<<<<< HEAD
        // קונסטרוקטור ללא פרמטרים
        public Person() { }
    }
}
=======
        public Person() { }
    }
}
>>>>>>> f814bc982c82016ba8a39fb3a3e241bc2a28d8dd
