namespace Models.Entities;

public partial class OsgpoBusinessRequest
{
    public int Id { get; set; }

    public string? ClientId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? JuridicalPersonName { get; set; }

    public string NaturalPersonBool { get; set; } = null!;

    public string? Address { get; set; }

    public string? DocumentTypeId { get; set; }

    public string? DocumentNumber { get; set; }

    public DateTime? DocumentGivedDate { get; set; }

    public string? Email { get; set; }

    public string? Phones { get; set; }

    public string? MainChief { get; set; }

    public string? ActivityKindId { get; set; }

    public string? ResidentBool { get; set; }

    public string? EconomicsSectorId { get; set; }

    public string? Iin { get; set; }

    public DateTime DateStart { get; set; }

    public DateTime DateEnd { get; set; }

    public bool? InsurerBool { get; set; }

    public string? Licnum { get; set; }

    public DateTime? Licdate { get; set; }

    public string? Paymenttype { get; set; }

    public string? Premium { get; set; }

    public string? PremiumDiscount { get; set; }

    public string? Inssum { get; set; }

    public string? Documents { get; set; }

    public string? InsuredList { get; set; }

    public string? CalcData { get; set; }

    public int? ProductId { get; set; }

    public int? Status { get; set; }

    public int? ManagerId { get; set; }

    public string? PreferredLang { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? CityId { get; set; }

    public string? Comment { get; set; }
}
