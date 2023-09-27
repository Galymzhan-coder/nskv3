namespace Models.Entities;

public partial class Faq
{
    public int Id { get; set; }

    /// <summary>
    /// Категория
    /// </summary>
    public int CategoryId { get; set; }

    /// <summary>
    /// Вопрос
    /// </summary>
    public string? Question { get; set; }

    /// <summary>
    /// Ответ
    /// </summary>
    public string? Answer { get; set; }

    /// <summary>
    /// Активность
    /// </summary>
    public short? IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public short? IsOften { get; set; }

    /// <summary>
    /// Позиция
    /// </summary>
    public int? Position { get; set; }

    public virtual ICollection<FaqTranslation> FaqTranslations { get; set; } = new List<FaqTranslation>();
}
