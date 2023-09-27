namespace Models.Entities;

public partial class CalculatorLog
{
    public int Id { get; set; }

    public int? PolicyId { get; set; }

    public string? CalcId { get; set; }

    public string? CalcType { get; set; }

    public int? CalcStatus { get; set; }

    public int? PersonType { get; set; }

    public string? Iin { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Fio { get; set; }

    public int? Step { get; set; }

    public int? Status { get; set; }

    public string? Debug { get; set; }

    public int? ManagerId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? LoggedAt { get; set; }

    public int? Event { get; set; }
}
