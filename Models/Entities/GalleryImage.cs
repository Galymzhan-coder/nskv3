namespace Models.Entities;

public partial class GalleryImage
{
    public int Id { get; set; }

    public int GalleryId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string? Filename { get; set; }

    public uint? Position { get; set; }

    public short? IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual Gallery Gallery { get; set; } = null!;
}
