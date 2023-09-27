namespace Models.Entities;

/// <summary>
/// Значения характеристик автомобиля
/// </summary>
public partial class NskCarCharacteristicValue
{
    public int Id { get; set; }

    public string Value { get; set; } = null!;

    /// <summary>
    /// Еденица измерения
    /// </summary>
    public string? Unit { get; set; }

    public int IdCarCharacteristic { get; set; }

    public int IdCarModification { get; set; }

    public int IdCarType { get; set; }
}
