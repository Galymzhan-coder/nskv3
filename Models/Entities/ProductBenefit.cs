namespace Models.Entities;

public partial class ProductBenefit
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Image { get; set; }

    public bool? IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual ICollection<ProductBenefitsTranslation> ProductBenefitsTranslations { get; set; } = new List<ProductBenefitsTranslation>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
