namespace Models.Entities;

public partial class ProductActionsTranslation
{
    public int ActionId { get; set; }

    public int LangId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public virtual ProductAction Action { get; set; } = null!;

    public virtual Language Lang { get; set; } = null!;
}
