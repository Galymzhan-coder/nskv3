namespace Models.Entities;

public partial class ProductRisksTranslation
{
    public int RiskId { get; set; }

    public int LangId { get; set; }

    public string? Title { get; set; }

    public virtual Language Lang { get; set; } = null!;

    public virtual ProductRisk Risk { get; set; } = null!;
}
