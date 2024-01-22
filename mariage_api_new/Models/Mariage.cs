namespace mariage_api_new.Models;

public class Mariage
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    
    public string ThemeTable { get; set; }

    // Relations avec d'autres modèles, si nécessaire
    public ICollection<Invite> Invites { get; set; }
}