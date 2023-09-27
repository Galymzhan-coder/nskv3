namespace Models.Entities;

public partial class ManagerLog
{
    public int Id { get; set; }

    public int ManagerId { get; set; }

    public string Action { get; set; } = null!;

    public string Url { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public int Type { get; set; }

    public int Section { get; set; }

    public virtual UserDTO Manager { get; set; } = null!;
}
