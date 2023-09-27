namespace Models.Entities;

public partial class InsuranceCase
{
    public int Id { get; set; }

    /// <summary>
    /// Продукт
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Что произошло
    /// </summary>
    public int TypeId { get; set; }

    /// <summary>
    /// Виновник
    /// </summary>
    public short? WhoGuilty { get; set; }

    /// <summary>
    /// Описание ситуации
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Точный адрес
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// Дата
    /// </summary>
    public DateTime? Date { get; set; }

    /// <summary>
    /// Время
    /// </summary>
    public TimeSpan? Time { get; set; }

    /// <summary>
    /// ИИН
    /// </summary>
    public string? Iin { get; set; }

    /// <summary>
    /// Номер полиса
    /// </summary>
    public string? PolicyNumber { get; set; }

    /// <summary>
    /// Телефон
    /// </summary>
    public string? Phone { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual ICollection<InsuranceCaseImage> InsuranceCaseImages { get; set; } = new List<InsuranceCaseImage>();
}
