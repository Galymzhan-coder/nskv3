namespace Models.Entities;

public partial class PagesTranslation
{
    public int PageId { get; set; }

    public int LangId { get; set; }

    /// <summary>
    /// Наименование
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Краткий Текст
    /// </summary>
    public string? ShortText { get; set; }

    /// <summary>
    /// Текст
    /// </summary>
    public string? Text { get; set; }

    public string? MetaTitle { get; set; }

    public string? MetaDescription { get; set; }

    public string? MetaKeywords { get; set; }

    public virtual Language Lang { get; set; } = null!;

    public virtual Page Page { get; set; } = null!;
}
