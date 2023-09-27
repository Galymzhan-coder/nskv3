namespace Models.Entities;

public partial class InsuranceCaseImage
{
    public int Id { get; set; }

    /// <summary>
    /// Случай
    /// </summary>
    public int CaseId { get; set; }

    /// <summary>
    /// Изображение
    /// </summary>
    public string Image { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual InsuranceCase Case { get; set; } = null!;
}
