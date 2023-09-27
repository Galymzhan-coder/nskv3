namespace Models.Entities;

public partial class ContactsTranslation
{
    public int ContactId { get; set; }

    public int LangId { get; set; }

    public string? Title { get; set; }

    public string? Address { get; set; }

    public string? WorkHours { get; set; }

    public string? Director { get; set; }

    public virtual Contact Contact { get; set; } = null!;

    public virtual Language Lang { get; set; } = null!;
}
