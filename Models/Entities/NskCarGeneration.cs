namespace Models.Entities;

/// <summary>
/// Поколения Моделей
/// </summary>
public partial class NskCarGeneration
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int IdCarModel { get; set; }

    public string? YearBegin { get; set; }

    public string? YearEnd { get; set; }

    public uint DateCreate { get; set; }

    public uint? DateUpdate { get; set; }

    public int IdCarType { get; set; }
}
