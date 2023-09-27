namespace Models.Entities;

public partial class Page
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public uint CategoryId { get; set; }

    public string? Title { get; set; }

    public string? ShortText { get; set; }

    public string? Text { get; set; }

    public string Sefname { get; set; } = null!;

    public string? Image { get; set; }

    public DateTime PublishDate { get; set; }

    public uint? Views { get; set; }

    public short? IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public string? MetaDescription { get; set; }

    public string? MetaKeywords { get; set; }

    public string? MetaImage { get; set; }

    public string? MetaTitle { get; set; }

    public short? IsMainpage { get; set; }

    public string? DownloadFile { get; set; }

    public virtual ICollection<PagesTranslation> PagesTranslations { get; set; } = new List<PagesTranslation>();

    public virtual UserDTO User { get; set; } = null!;
}
