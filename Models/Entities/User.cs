namespace Models.Entities;

public partial class UserDTO
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Role { get; set; }

    public short? IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public string Phone { get; set; } = null!;

    public int? SmsCode { get; set; }

    public string Iin { get; set; } = null!;

    public string? DocNum { get; set; }

    public short? IsConnected { get; set; }

    public string? OnesignalId { get; set; }

    public int? SendinblueId { get; set; }

    public int? NskClientId { get; set; }

    public virtual ICollection<AdminLog> AdminLogs { get; set; } = new List<AdminLog>();

    public virtual ICollection<ManagerLog> ManagerLogs { get; set; } = new List<ManagerLog>();

    public virtual ICollection<NskApiErrorLog> NskApiErrorLogs { get; set; } = new List<NskApiErrorLog>();

    public virtual ICollection<Page> Pages { get; set; } = new List<Page>();

    public virtual ICollection<UserDevice> UserDevices { get; set; } = new List<UserDevice>();

    public virtual ICollection<UsersCode> UsersCodes { get; set; } = new List<UsersCode>();
}
