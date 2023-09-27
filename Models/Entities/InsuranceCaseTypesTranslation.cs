namespace Models.Entities;

public partial class InsuranceCaseTypesTranslation
{
    public int TypeId { get; set; }

    public int LangId { get; set; }

    public string? Title { get; set; }

    public virtual Language Lang { get; set; } = null!;

    public virtual InsuranceCaseType Type { get; set; } = null!;
}
