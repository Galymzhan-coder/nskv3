namespace Models.Entities;

public partial class City
{
    public int Id { get; set; }

    /// <summary>
    /// Наименование
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Активность
    /// </summary>
    public short? IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public string? Phone { get; set; }

    public string? PhoneSecondary { get; set; }

    /// <summary>
    /// Город в базе GeoIP
    /// </summary>
    public string? GeoipCity { get; set; }

    public virtual ICollection<CitiesTranslation> CitiesTranslations { get; set; } = new List<CitiesTranslation>();

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual ICollection<OffersReview> OffersReviews { get; set; } = new List<OffersReview>();
}
