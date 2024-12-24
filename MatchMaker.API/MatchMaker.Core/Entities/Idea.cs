using MatchMaker.Core.Entities.MatchMaker.Core.Entities;
using MatchMaker.Core.Entities;

public class Idea
{
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
    }
}
