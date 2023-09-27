namespace Models.Entities;

public partial class BlogCategory
{
    public int Id { get; set; }

    /// <summary>
    /// Наименование
    /// </summary>
    public string? Title { get; set; }

    public string? Sefname { get; set; }

    /// <summary>
    /// Активность
    /// </summary>
    public short? IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual ICollection<BlogCategoriesTranslation> BlogCategoriesTranslations { get; set; } = new List<BlogCategoriesTranslation>();

    public virtual ICollection<Blog> Blogs { get; set; } = new List<Blog>();
}
