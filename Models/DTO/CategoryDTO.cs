namespace Models.DTO;

public partial class CategoryDTO
{
    public int Id { get; set; }

    public uint? parent_id { get; set; }

    public string? Title { get; set; }

    public string Sefname { get; set; } = null!;

    public string? Description { get; set; }

    public short? IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public uint? Root { get; set; }

    public uint? Lft { get; set; }

    public uint? Rgt { get; set; }

    public uint? Level { get; set; }

}
