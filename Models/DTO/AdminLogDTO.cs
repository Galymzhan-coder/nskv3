namespace Models.DTO;

public partial class AdminLogDTO
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Module { get; set; } = null!;

    public string Action { get; set; } = null!;

    public int ItemId { get; set; }

    public string? Message { get; set; }

    public DateTime CreateDate { get; set; }

}
