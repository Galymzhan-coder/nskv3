namespace Models.Entities;

public partial class CalculatorHintsTranslation
{
    public int HintId { get; set; }

    public int LangId { get; set; }

    public string? Title { get; set; }

    public string? Value { get; set; }

    public virtual CalculatorHint Hint { get; set; } = null!;

    public virtual Language Lang { get; set; } = null!;
}
