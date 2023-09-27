namespace Models.Entities;

public partial class UsersCode
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int Code { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual UserDTO User { get; set; } = null!;
}
