namespace Models.Entities;

public partial class ProductRule
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? ProductId { get; set; }

    public bool? IsActual { get; set; }

    public DateTime? ActualDate { get; set; }

    public string? Lang { get; set; }

    public string? File { get; set; }
}
