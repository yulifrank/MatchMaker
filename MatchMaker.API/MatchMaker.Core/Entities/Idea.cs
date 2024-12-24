using MatchMaker.Core.Entities.MatchMaker.Core.Entities;
using MatchMaker.Core.Entities;

public class Idea
{
<<<<<<< HEAD
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
=======
    public int Id { get; set; }
    public int GuyId { get; set; }  // מזהה של Guy
    public int GirlId { get; set; }  // מזהה של Girl
    public Guy Guy { get; set; }  // קשר ל-Guy
    public Girl Girl { get; set; }  // קשר ל-Girl
    public string StatusDescription { get; set; }

    // קונסטרוקטור ללא פרמטרים
    public Idea() { }

    // קונסטרוקטור עם פרמטרים
    public Idea(int guyId, int girlId, string statusDescription)
    {
        GuyId = guyId;
        GirlId = girlId;
        StatusDescription = statusDescription;
>>>>>>> f814bc982c82016ba8a39fb3a3e241bc2a28d8dd
    }
}
