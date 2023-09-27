namespace Models.Entities;

public partial class ProductBenefitsTranslation
{
    public int BenefitId { get; set; }

    public int LangId { get; set; }

    public string? Title { get; set; }

    public virtual ProductBenefit Benefit { get; set; } = null!;

    public virtual Language Lang { get; set; } = null!;
}
