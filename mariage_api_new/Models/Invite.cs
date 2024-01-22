namespace mariage_api_new.Models;

public class Invite
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public TypeInvite Type { get; set; }
    public int MariageId { get; set; }

    // Relation avec Mariage
    public Mariage Mariage { get; set; }
}

public enum TypeInvite
{
    FamilleMarie,
    AmisParentsMarie,
    AmisMarie,
    FamilleMariee,
    AmisParentsMariee,
    AmisMariee
}