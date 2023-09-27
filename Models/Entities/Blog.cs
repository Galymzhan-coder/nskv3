namespace Models.Entities;

public partial class Blog
{
    public int Id { get; set; }

    /// <summary>
    /// Категория
    /// </summary>
    public int CategoryId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    /// <summary>
    /// Текст
    /// </summary>
    public string? Text { get; set; }

    public DateTime PublishDate { get; set; }

    public string? Sefname { get; set; }

    /// <summary>
    /// Просмотры
    /// </summary>
    public int? Views { get; set; }

    /// <summary>
    /// Активность
    /// </summary>
    public short? IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public string? Image { get; set; }

    public short? IsUsefull { get; set; }

    public short? IsMainpage { get; set; }

    public virtual ICollection<BlogsTranslation> BlogsTranslations { get; set; } = new List<BlogsTranslation>();

    public virtual BlogCategory Category { get; set; } = null!;
}
