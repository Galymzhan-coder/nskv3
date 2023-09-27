namespace Models.Entities;

public partial class ContentTranslation
{
    public int ContentId { get; set; }

    public int LangId { get; set; }

    /// <summary>
    /// Заголовок
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Описание
    /// </summary>
    public string? Text { get; set; }

    public string? MetaTitle { get; set; }

    public string? MetaDescription { get; set; }

    public string? MetaKeywords { get; set; }

    public virtual Content Content { get; set; } = null!;

    public virtual Language Lang { get; set; } = null!;
}
