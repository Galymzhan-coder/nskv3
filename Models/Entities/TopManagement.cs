namespace Models.Entities;

public partial class TopManagement
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public string? Title { get; set; }

    public string? Text { get; set; }

    public string? Image { get; set; }

    public string? ImageDescription { get; set; }

    public int Position { get; set; }

    public int Weight { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<TopManagementTranslation> TopManagementTranslations { get; set; } = new List<TopManagementTranslation>();
}
