namespace Models.Entities;

public partial class OgpoFormRequest
{
    public int Id { get; set; }

    public string? Iin { get; set; }

    public string? Fio { get; set; }

    public string? Phone { get; set; }

    public int? CountryId { get; set; }

    public string? PrefCh { get; set; }

    public string? Data { get; set; }

    public string? Documents { get; set; }

    public string? OgpoType { get; set; }

    public int? Status { get; set; }

    public int? ManagerId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
