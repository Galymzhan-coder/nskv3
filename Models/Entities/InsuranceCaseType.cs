namespace Models.Entities;

public partial class InsuranceCaseType
{
    public int Id { get; set; }

    public string? Title { get; set; }

    /// <summary>
    /// Активность
    /// </summary>
    public short? IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual ICollection<InsuranceCaseTypesTranslation> InsuranceCaseTypesTranslations { get; set; } = new List<InsuranceCaseTypesTranslation>();
}
