namespace Models.Entities;

public partial class GoszakupTender
{
    public int Id { get; set; }

    public string? LotId { get; set; }

    public string? Name { get; set; }

    public string? Href { get; set; }

    public string? Source { get; set; }

    public bool? IsNotified { get; set; }

    public bool? IsViewed { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? Amount { get; set; }
}
