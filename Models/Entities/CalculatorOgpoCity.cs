namespace Models.Entities;

public partial class CalculatorOgpoCity
{
    public int Id { get; set; }

    /// <summary>
    /// Наименование
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// ID региона
    /// </summary>
    public int RegionId { get; set; }

    /// <summary>
    /// Город обл. значения
    /// </summary>
    public short? IsBigCity { get; set; }

    public short? IsCheckCity { get; set; }

    public virtual ICollection<CalculatorOgpoCitiesTranslation> CalculatorOgpoCitiesTranslations { get; set; } = new List<CalculatorOgpoCitiesTranslation>();

    public virtual ICollection<CalculatorOgpoCityCode> CalculatorOgpoCityCodes { get; set; } = new List<CalculatorOgpoCityCode>();
}
