namespace Models.Entities;

public partial class MenuItem
{
    public int Id { get; set; }

    public int MenuId { get; set; }

    public int LangId { get; set; }

    public int? ParentId { get; set; }

    public string Title { get; set; } = null!;

    public string? Link { get; set; }

    public string? Params { get; set; }

    public short? IsNewWindow { get; set; }

    public short? IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public uint? Root { get; set; }

    public uint? Lft { get; set; }

    public uint? Rgt { get; set; }

    public uint? Level { get; set; }

    public virtual Language Lang { get; set; } = null!;

    public virtual Menu Menu { get; set; } = null!;
}
