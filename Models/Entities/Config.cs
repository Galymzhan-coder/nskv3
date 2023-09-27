namespace Models.Entities;

public partial class Config
{
    public int Id { get; set; }

    public string Param { get; set; } = null!;

    /// <summary>
    /// Значение
    /// </summary>
    public string? Value { get; set; }

    /// <summary>
    /// Наименование
    /// </summary>
    public string? Title { get; set; }

    public DateTime? UpdateDate { get; set; }
}
