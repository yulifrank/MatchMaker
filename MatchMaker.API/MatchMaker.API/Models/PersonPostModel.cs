using MatchMaker.Core.Entities;

namespace MatchMaker.API.Models
{
    public class PersonPostModel
    {
        public string FirstName { get; set; } // חובה
        public string LastName { get; set; } // חובה
        public DateOnly Birthday { get; set; } // חובה
        public int OpennessLevel { get; set; } // חובה
        public string FatherName { get; set; } // חובה
        public string MotherName { get; set; } // חובה
        public float Height { get; set; } // חובה
        public Motza Motza { get; set; } // חובה
        public string? Remark { get; set; } // אופציונלי
        public string? Img { get; set; } // אופציונלי
        public string? Resume { get; set; } // אופציונלי
    }

}
