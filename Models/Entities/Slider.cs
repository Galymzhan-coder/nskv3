namespace Models.Entities;

public partial class Slider
{
    public int Id { get; set; }

    /// <summary>
    /// Язык
    /// </summary>
    public int LangId { get; set; }

    /// <summary>
    /// Заголовок
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// Описание
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Ссылка с кнопки
    /// </summary>
    public string? Link { get; set; }

    /// <summary>
    /// Изображение
    /// </summary>
    public string? Image { get; set; }

    /// <summary>
    /// Позиция
    /// </summary>
    public int? Position { get; set; }

    /// <summary>
    /// Активность
    /// </summary>
    public short? IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }
}
