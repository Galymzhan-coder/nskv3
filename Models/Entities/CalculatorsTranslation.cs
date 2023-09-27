namespace Models.Entities;

public partial class CalculatorsTranslation
{
    public int CalculatorId { get; set; }

    public int LangId { get; set; }

    public string? Title { get; set; }

    public virtual Calculator Calculator { get; set; } = null!;

    public virtual Language Lang { get; set; } = null!;
}
