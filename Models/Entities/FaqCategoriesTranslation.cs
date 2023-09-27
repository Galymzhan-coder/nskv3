namespace Models.Entities;

public partial class FaqCategoriesTranslation
{
    public int CategoryId { get; set; }

    public int LangId { get; set; }

    public string? Title { get; set; }

    public virtual FaqCategory Category { get; set; } = null!;

    public virtual Language Lang { get; set; } = null!;
}
