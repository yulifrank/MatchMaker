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
        public string LasttName { get; set; }
        public DateOnly Birthday { get; set; }
        public int OpennessLevel { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public float Hight { get; set; }
        public Motza Motza { get; set; }
        public string Remark { get; set; }
        public string Img { get; set; }
        public string Resume { get; set; }

        // קונסטרוקטור של Person
        public Person(string firstName, string lastName, DateOnly birthday, int opennessLevel, string fatherName, string motherName, float hight, Motza motza, string remark = "", string resume = null, string img = null)
        {
            Id=IdPerson++;
            FirstName = firstName;
            LasttName = lastName;
            Birthday = birthday;
            OpennessLevel = opennessLevel;
            FatherName = fatherName;
            MotherName = motherName;
            Hight = hight;
            Motza = motza;
            Remark = remark;
            Img = img;
            Resume = resume;
        }

        // קונסטרוקטור ללא פרמטרים
        public Person() { }
    }
}
