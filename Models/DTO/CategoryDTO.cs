using Models.DTO.Interfaces;

namespace Models.DTO;

public partial class CategoryDTO:IDto
{
    public int Id { get; set; }

    public uint? parent_id { get; set; }

    public string? Title { get; set; }

    public string Sefname { get; set; } = null!;

    public string? Description { get; set; }

    public short? is_active { get; set; }

    public DateTime Create_Date { get; set; }

    public DateTime Update_Date { get; set; }

    public uint? Root { get; set; }

    public uint? Lft { get; set; }

    public uint? Rgt { get; set; }

    public uint? Level { get; set; }

}
