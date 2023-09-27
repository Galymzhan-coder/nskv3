namespace Models.Entities;

public partial class CaseRequest
{
    public int Id { get; set; }

    public int? IsInjured { get; set; }

    public DateTime? CaseDate { get; set; }

    public int? CaseRegion { get; set; }

    public string? CaseDetails { get; set; }

    public string? Iin { get; set; }

    public string? Regnum { get; set; }

    public string? Fio { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? PolicyNum { get; set; }

    public string? CounterpartIin { get; set; }

    public string? CounterpartFio { get; set; }

    public string? CounterpartRegnum { get; set; }

    public string? Documents { get; set; }

    public string? Product { get; set; }

    public int? Status { get; set; }

    public int? ManagerId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
