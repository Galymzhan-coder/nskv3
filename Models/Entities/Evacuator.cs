namespace Models.Entities;

public partial class Evacuator
{
    public int Id { get; set; }

    /// <summary>
    /// Язык
    /// </summary>
    public int? LangId { get; set; }

    /// <summary>
    /// User Id
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// ФИО
    /// </summary>
    public string FullName { get; set; } = null!;

    /// <summary>
    /// Телефон
    /// </summary>
    public string? Phone { get; set; }

    public string? City { get; set; }

    /// <summary>
    /// Адрес
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// Комментарий
    /// </summary>
    public string? Comment { get; set; }

    /// <summary>
    /// Тип
    /// </summary>
    public short Type { get; set; }

    /// <summary>
    /// Статус
    /// </summary>
    public short Status { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }
}
