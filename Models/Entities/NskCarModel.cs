namespace Models.Entities;

/// <summary>
/// Модели автомобилей
/// </summary>
public partial class NskCarModel
{
    /// <summary>
    /// ID
    /// </summary>
    public int Id { get; set; }

    public int IdCarMark { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? DateCreate { get; set; }

    public DateTime? DateUpdate { get; set; }

    public int IdCarType { get; set; }

    public string? NameRus { get; set; }
}
