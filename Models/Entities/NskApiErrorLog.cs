namespace Models.Entities;

public partial class NskApiErrorLog
{
    public int Id { get; set; }

    /// <summary>
    /// Код ошибки
    /// </summary>
    public string Code { get; set; } = null!;

    public string? Message { get; set; }

    /// <summary>
    /// Группа
    /// </summary>
    public string Category { get; set; } = null!;

    /// <summary>
    /// Название запроса
    /// </summary>
    public string RequestName { get; set; } = null!;

    /// <summary>
    /// Параметры запроса
    /// </summary>
    public string? Params { get; set; }

    /// <summary>
    /// ИИН клиента в запросе
    /// </summary>
    public string? Iin { get; set; }

    /// <summary>
    /// Статус ошибки
    /// </summary>
    public int? Status { get; set; }

    /// <summary>
    /// Пользователь
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Номер телефона при рассчете
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// Дата создания
    /// </summary>
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Дата обновления
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Класс калькулятора
    /// </summary>
    public string? CalculatorModel { get; set; }

    /// <summary>
    /// ID калькулятора в MongoDB
    /// </summary>
    public string? CalculatorId { get; set; }

    public virtual UserDTO? User { get; set; }
}
