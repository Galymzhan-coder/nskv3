namespace Models.Entities;

public partial class Review
{
    public int Id { get; set; }

    /// <summary>
    /// Язык
    /// </summary>
    public int LangId { get; set; }

    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Должность
    /// </summary>
    public string Description { get; set; } = null!;

    public string? Review1 { get; set; }

    /// <summary>
    /// Большое изображение
    /// </summary>
    public string? LargeImage { get; set; }

    /// <summary>
    /// Маленькое изображение
    /// </summary>
    public string? Image { get; set; }

    /// <summary>
    /// Видео-файл
    /// </summary>
    public string? Video { get; set; }

    /// <summary>
    /// Активность
    /// </summary>
    public short? IsActive { get; set; }

    /// <summary>
    /// Позиция
    /// </summary>
    public int? Position { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
