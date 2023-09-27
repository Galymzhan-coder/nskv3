namespace Models.Entities;

public partial class OffersReview
{
    public int Id { get; set; }

    public int? CityId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Text { get; set; }

    public bool? IsNew { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual City? City { get; set; }
}
