namespace Models.Entities;

public partial class Gallery
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public short? IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual ICollection<GalleryImage> GalleryImages { get; set; } = new List<GalleryImage>();
}
