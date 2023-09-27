namespace Models.Entities;

public partial class CalculatorHint
{
    public int Id { get; set; }

    public int? CalculatorId { get; set; }

    public string? Title { get; set; }

    public int? Step { get; set; }

    public string Key { get; set; } = null!;

    public string? Value { get; set; }

    public virtual ICollection<CalculatorHintsTranslation> CalculatorHintsTranslations { get; set; } = new List<CalculatorHintsTranslation>();
}
