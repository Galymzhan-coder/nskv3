namespace Models.Entities;

public partial class PromoSmsNotivication
{
    public uint Id { get; set; }

    public string? Phone { get; set; }

    public string? Promo { get; set; }

    public string? Product { get; set; }

    public string? CreatedAt { get; set; }

    public string? UpdatedAt { get; set; }
}
