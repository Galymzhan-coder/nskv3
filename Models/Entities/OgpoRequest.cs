namespace Models.Entities;

public partial class OgpoRequest
{
    public int Id { get; set; }

    public string? Phone { get; set; }

    public string? Type { get; set; }

    public int? Status { get; set; }

    public int? ManagerId { get; set; }

    public string? Documents { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? Email { get; set; }

    public string? Extra { get; set; }

    public int? IsResident { get; set; }

    public string? Customers { get; set; }

    public string? Vehicles { get; set; }
}
