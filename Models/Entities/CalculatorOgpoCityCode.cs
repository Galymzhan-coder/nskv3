namespace Models.Entities;

public partial class CalculatorOgpoCityCode
{
    public int RegionId { get; set; }

    public string Code { get; set; } = null!;

    public virtual CalculatorOgpoCity Region { get; set; } = null!;
}
