namespace Models.Entities;

public partial class ProductCategoriesTranslation
{
    public int CategoryId { get; set; }

    public int LangId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public virtual ProductCategory Category { get; set; } = null!;

    public virtual Language Lang { get; set; } = null!;
}
