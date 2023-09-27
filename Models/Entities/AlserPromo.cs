namespace Models.Entities;

public partial class AlserPromo
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public int? Sum { get; set; }

    public string? AgreeId { get; set; }

    public DateTime? ActivationDate { get; set; }
}
