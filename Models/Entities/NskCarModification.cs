namespace Models.Entities;

/// <summary>
/// Модификации автомобилей
/// </summary>
public partial class NskCarModification
{
    /// <summary>
    /// ID
    /// </summary>
    public int Id { get; set; }

    public int IdCarSerie { get; set; }

    public int IdCarModel { get; set; }

    public string Name { get; set; } = null!;

    public uint? DateCreate { get; set; }

    public uint? DateUpdate { get; set; }

    public int IdCarType { get; set; }
}
