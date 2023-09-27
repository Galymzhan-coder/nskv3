namespace Models.Entities;

public partial class BusinessOsgpo
{
    public int Id { get; set; }

    public string ClientId { get; set; } = null!;

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

    public string? InsurerBool { get; set; }

    public string? Licnum { get; set; }

    public DateTime? Licdate { get; set; }

    public string? Regregion { get; set; }

    public string? Tarif { get; set; }

    public string? Paymenttype { get; set; }

    public string? Premium { get; set; }

    public string? PremiumDiscount { get; set; }

    public string? Inssum { get; set; }

    public string? DocUd { get; set; }

    public string? DocLic { get; set; }

    public string? DocTer { get; set; }

    public string? PreferredLang { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
