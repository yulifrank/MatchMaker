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
        public string LastName { get; set; } // תוקן שם השדה מ-LasttName ל-LastName
        public DateOnly Birthday { get; set; }
        public int OpennessLevel { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public float Height { get; set; }  // תוקן מ-Hight ל-Height
        public Motza Motza { get; set; }
        public string Remark { get; set; }
        public string Img { get; set; }
        public string Resume { get; set; }

        public Person(string firstName, string lastName, DateOnly birthday, int opennessLevel, string fatherName, string motherName, float height, Motza motza, string remark = "", string resume = null, string img = null)
        {
            Id = IdPerson++;
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            OpennessLevel = opennessLevel;
            FatherName = fatherName;
            MotherName = motherName;
            Height = height;
            Motza = motza;
            Remark = remark;
            Img = img;
            Resume = resume;
        }

        public Person() { }
    }
}