namespace Models.Entities;

public partial class ProductRisk
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Image { get; set; }

    /// <summary>
    /// Активность
    /// </summary>
    public short? IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual ICollection<ProductRisksTranslation> ProductRisksTranslations { get; set; } = new List<ProductRisksTranslation>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
