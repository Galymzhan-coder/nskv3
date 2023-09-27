namespace Models.Entities;

public partial class CategoriesTranslation
{
    public int CategoryId { get; set; }

    public int LangId { get; set; }

    /// <summary>
    /// Заголовок
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Описание
    /// </summary>
    public string? Description { get; set; }

    public virtual CategoryDTO Category { get; set; } = null!;

    public virtual Language Lang { get; set; } = null!;
}
