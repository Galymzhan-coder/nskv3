namespace Models.Entities;

public partial class FaqTranslation
{
    public int FaqId { get; set; }

    public int LangId { get; set; }

    public string? Question { get; set; }

    public string? Answer { get; set; }

    public virtual Faq Faq { get; set; } = null!;

    public virtual Language Lang { get; set; } = null!;
}
