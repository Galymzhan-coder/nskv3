namespace Models.Entities;

public partial class AdminLog
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Module { get; set; } = null!;

    public string Action { get; set; } = null!;

    public int ItemId { get; set; }

    public string? Message { get; set; }

    public DateTime CreateDate { get; set; }

    public virtual UserDTO User { get; set; } = null!;
}
