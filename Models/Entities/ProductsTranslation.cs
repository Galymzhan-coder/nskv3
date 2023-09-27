namespace Models.Entities;

public partial class ProductsTranslation
{
    public int ProductId { get; set; }

    public int LangId { get; set; }

    public string? Title { get; set; }

    public string? Text { get; set; }

    public string? Description { get; set; }

    public string? ShortDescription { get; set; }

    public string? SuggestedLabel { get; set; }

    public string? SuggestedButtonLabel { get; set; }

    public string? BannerTitle { get; set; }

    public string? BannerText { get; set; }

    public string? MetaTitle { get; set; }

    public string? MetaDescription { get; set; }

    public string? MetaKeywords { get; set; }

    public virtual Language Lang { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
