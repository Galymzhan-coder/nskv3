namespace Models.Entities;

public partial class UsersSendSmsUser
{
    public int Id { get; set; }

    public string? Phone { get; set; }

    public int? Code { get; set; }
}
