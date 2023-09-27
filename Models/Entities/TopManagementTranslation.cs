namespace Models.Entities;

public partial class TopManagementTranslation
{
    public int ManagerId { get; set; }

    public int LangId { get; set; }

    public string? FullName { get; set; }

    /// <summary>
    /// Описание
    /// </summary>
    public string? Text { get; set; }

    public string? Title { get; set; }

    public virtual Language Lang { get; set; } = null!;

    public virtual TopManagement Manager { get; set; } = null!;
}
