namespace Models.Entities;

public partial class UsersLog3
{
    public uint Id { get; set; }

    public int? UserId { get; set; }

    public string? Action { get; set; }

    public string? Ip { get; set; }

    public string? Request { get; set; }

    public string? Url { get; set; }

    public string? Data { get; set; }

    public string? CreatedAt { get; set; }

    public string? UpdatedAt { get; set; }

    public string? Login { get; set; }
}
