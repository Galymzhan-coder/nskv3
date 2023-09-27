namespace Models.Entities;

public partial class ProductAction
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    /// <summary>
    /// Ссылка
    /// </summary>
    public string? Link { get; set; }

    /// <summary>
    /// Изображение
    /// </summary>
    public string? Image { get; set; }

    /// <summary>
    /// Активность
    /// </summary>
    public short? IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual Product? Product { get; set; }

    public virtual ICollection<ProductActionsTranslation> ProductActionsTranslations { get; set; } = new List<ProductActionsTranslation>();
}
