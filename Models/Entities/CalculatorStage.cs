namespace Models.Entities;

public partial class CalculatorStage
{
    public int Id { get; set; }

    /// <summary>
    /// Калькулятор
    /// </summary>
    public int CalculatorId { get; set; }

    /// <summary>
    /// Номер этапа
    /// </summary>
    public short Number { get; set; }

    public string? Title { get; set; }

    /// <summary>
    /// Описание этапа
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Порядок
    /// </summary>
    public int? Position { get; set; }

    /// <summary>
    /// Активность
    /// </summary>
    public short? IsActive { get; set; }

    /// <summary>
    /// Родитель
    /// </summary>
    public int? ParentId { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual ICollection<CalculatorStagesTranslation> CalculatorStagesTranslations { get; set; } = new List<CalculatorStagesTranslation>();
}
