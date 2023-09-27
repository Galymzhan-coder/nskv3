namespace Models.Entities;

public partial class CitiesTranslation
{
    public int CityId { get; set; }

    public int LangId { get; set; }

    public string? Title { get; set; }

    public virtual City City { get; set; } = null!;

    public virtual Language Lang { get; set; } = null!;
}
