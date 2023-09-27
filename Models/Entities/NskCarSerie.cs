namespace Models.Entities;

/// <summary>
/// Cерии автомобилей
/// </summary>
public partial class NskCarSerie
{
    /// <summary>
    /// ID
    /// </summary>
    public int Id { get; set; }

    public int IdCarModel { get; set; }

    public string Name { get; set; } = null!;

    public uint? DateCreate { get; set; }

    public uint? DateUpdate { get; set; }

    public int? IdCarGeneration { get; set; }

    public int IdCarType { get; set; }
}
