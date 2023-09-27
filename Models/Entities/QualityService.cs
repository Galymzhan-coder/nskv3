namespace Models.Entities;

public partial class QualityService
{
    public int Id { get; set; }

    public int MessageType { get; set; }

    public string Message { get; set; } = null!;

    public string? Iin { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public int CityId { get; set; }

    public int Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? ManagerId { get; set; }

    /// <summary>
    /// Файл
    /// </summary>
    public string? File { get; set; }

    public string? UtmLabels { get; set; }
}
