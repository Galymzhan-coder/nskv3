namespace Models.Entities;

public partial class Product
{
    public int Id { get; set; }

    /// <summary>
    /// Категория
    /// </summary>
    public int CategoryId { get; set; }

    public string? Title { get; set; }

    public string? Sefname { get; set; }

    /// <summary>
    /// Краткое описание
    /// </summary>
    public string? ShortDescription { get; set; }

    /// <summary>
    /// Описание
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Маленькое изображение
    /// </summary>
    public string? SmallImage { get; set; }

    /// <summary>
    /// Большое изображение
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

    /// <summary>
    /// Большая плитка
    /// </summary>
    public short? IsLarge { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public int? CalculatorId { get; set; }

    public string? Text { get; set; }

    public string? SuggestedLabel { get; set; }

    public string? SuggestedButtonLabel { get; set; }

    /// <summary>
    /// Обычная страница продукта с заявкой
    /// </summary>
    public short? IsPlainPage { get; set; }

    public bool HasBanner { get; set; }

    public string? BannerTitle { get; set; }

    public string? BannerText { get; set; }

    public string? BannerImage { get; set; }

    public bool? HasDescription { get; set; }

    public string? MetaDescription { get; set; }

    public string? MetaKeywords { get; set; }

    public string? MetaImage { get; set; }

    public string? MetaTitle { get; set; }

    public virtual ProductCategory Category { get; set; } = null!;

    public virtual ICollection<ProductAction> ProductActions { get; set; } = new List<ProductAction>();

    public virtual ICollection<ProductsSuggest> ProductsSuggests { get; set; } = new List<ProductsSuggest>();

    public virtual ICollection<ProductsTranslation> ProductsTranslations { get; set; } = new List<ProductsTranslation>();

    public virtual ICollection<ProductBenefit> ProductBenefits { get; set; } = new List<ProductBenefit>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual ICollection<ProductRisk> Risks { get; set; } = new List<ProductRisk>();
}
