namespace Models.Entities;

public partial class Promo
{
    public int Id { get; set; }

    /// <summary>
    /// Название промо
    /// </summary>
    public string Promo1 { get; set; } = null!;

    /// <summary>
    /// Процент скидки
    /// </summary>
    public int Percent { get; set; }

    /// <summary>
    /// Активность
    /// </summary>
    public int? IsActive { get; set; }

    /// <summary>
    /// Дата создания
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Дата обновления
    /// </summary>
    public DateTime? UpdateDate { get; set; }

    /// <summary>
    /// Калькулятор
    /// </summary>
    public int CalculatorId { get; set; }
}
