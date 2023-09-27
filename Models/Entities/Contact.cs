namespace Models.Entities;

public partial class Contact
{
    public int Id { get; set; }

    /// <summary>
    /// Город
    /// </summary>
    public int CityId { get; set; }

    /// <summary>
    /// Наименование
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Телефоны
    /// </summary>
    public string? Phones { get; set; }

    /// <summary>
    /// E-mail
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Адрес
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// Долгота
    /// </summary>
    public string? Longitude { get; set; }

    /// <summary>
    /// Широта
    /// </summary>
    public string? Latitude { get; set; }

    /// <summary>
    /// Режим работы
    /// </summary>
    public string? WorkHours { get; set; }

    /// <summary>
    /// Директор
    /// </summary>
    public string? Director { get; set; }

    public short? IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public bool? IsPaymentCenter { get; set; }

    public virtual City City { get; set; } = null!;

    public virtual ICollection<ContactsTranslation> ContactsTranslations { get; set; } = new List<ContactsTranslation>();
}
