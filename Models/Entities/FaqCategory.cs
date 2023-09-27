namespace Models.Entities;

public partial class FaqCategory
{
    public int Id { get; set; }

    /// <summary>
    /// Наименование
    /// </summary>
    public string? Title { get; set; }

    public string? Sefname { get; set; }

    /// <summary>
    /// Родительская категория
    /// </summary>
    public int ParentId { get; set; }

    /// <summary>
    /// Активность
    /// </summary>
    public short? IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public int? ProductId { get; set; }

    public virtual ICollection<FaqCategoriesTranslation> FaqCategoriesTranslations { get; set; } = new List<FaqCategoriesTranslation>();
}
