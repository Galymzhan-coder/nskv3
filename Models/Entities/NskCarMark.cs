namespace Models.Entities;

/// <summary>
/// Марки автомобилей
/// </summary>
public partial class NskCarMark
{
    /// <summary>
    /// ID
    /// </summary>
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? DateCreate { get; set; }

    public DateTime? DateUpdate { get; set; }

    public int IdCarType { get; set; }

    public string? NameRus { get; set; }
}
