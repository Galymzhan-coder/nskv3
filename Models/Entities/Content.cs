namespace Models.Entities;

public partial class Content
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Text { get; set; }

    public string Sefname { get; set; } = null!;

    public short? IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public string? MetaDescription { get; set; }

    public string? MetaKeywords { get; set; }

    public string? MetaImage { get; set; }

    public string? MetaTitle { get; set; }

    public virtual ICollection<ContentTranslation> ContentTranslations { get; set; } = new List<ContentTranslation>();
}
