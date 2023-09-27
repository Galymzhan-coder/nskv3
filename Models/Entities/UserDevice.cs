namespace Models.Entities;

public partial class UserDevice
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string DeviceId { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public virtual UserDTO User { get; set; } = null!;
}
