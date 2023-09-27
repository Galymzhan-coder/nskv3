namespace Models.Entities;

/// <summary>
/// Характеристики автомобилей
/// </summary>
public partial class NskCarCharacteristic
{
    /// <summary>
    /// id
    /// </summary>
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? IdParent { get; set; }

    public int IdCarType { get; set; }
}
