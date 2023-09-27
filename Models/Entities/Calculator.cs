namespace Models.Entities;

public partial class Calculator
{
    public int Id { get; set; }

    public string? Title { get; set; }

    /// <summary>
    /// Класс реализации
    /// </summary>
    public string Class { get; set; } = null!;

    /// <summary>
    /// ЧПУ
    /// </summary>
    public string? Sefname { get; set; }

    /// <summary>
    /// Активность
    /// </summary>
    public short? IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public int? Weight { get; set; }

    public virtual ICollection<CalculatorsTranslation> CalculatorsTranslations { get; set; } = new List<CalculatorsTranslation>();
}
