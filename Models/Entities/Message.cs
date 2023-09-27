namespace Models.Entities;

public partial class Message
{
    public int Id { get; set; }

    public string Language { get; set; } = null!;

    public string? Translation { get; set; }

    public virtual SourceMessage IdNavigation { get; set; } = null!;
}
