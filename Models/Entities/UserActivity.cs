namespace Models.Entities;

public partial class UserActivity
{
    public int Id { get; set; }

    public string? Product { get; set; }

    public string? Type { get; set; }

    public string? Phone { get; set; }

    public string? Data { get; set; }

    public int? Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
