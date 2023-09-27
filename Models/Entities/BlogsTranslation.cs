namespace Models.Entities;

public partial class BlogsTranslation
{
    public int BlogId { get; set; }

    public int LangId { get; set; }

    /// <summary>
    /// Заголовок
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Описание
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// text
    /// </summary>
    public string? Text { get; set; }

    public virtual Blog Blog { get; set; } = null!;

    public virtual Language Lang { get; set; } = null!;
}
