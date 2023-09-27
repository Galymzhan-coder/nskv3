namespace Models.Entities;

public partial class CalculatorStagesTranslation
{
    public int StageId { get; set; }

    public int LangId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public virtual Language Lang { get; set; } = null!;

    public virtual CalculatorStage Stage { get; set; } = null!;
}
