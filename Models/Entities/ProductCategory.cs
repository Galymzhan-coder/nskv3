namespace Models.Entities;

public partial class ProductCategory
{
    public int Id { get; set; }

    /// <summary>
    /// Пользователь продукта
    /// </summary>
    public short? CategoryType { get; set; }

    /// <summary>
    /// Наименование
    /// </summary>
    public string? Title { get; set; }

    public string? Sefname { get; set; }

    /// <summary>
    /// Описание
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Изображение
    /// </summary>
    public string? Image { get; set; }

    /// <summary>
    /// Активность
    /// </summary>
    public short? IsActive { get; set; }

    /// <summary>
    /// Позиция
    /// </summary>
    public int? Position { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public string? Icon { get; set; }

    public virtual ICollection<ProductCategoriesTranslation> ProductCategoriesTranslations { get; set; } = new List<ProductCategoriesTranslation>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
