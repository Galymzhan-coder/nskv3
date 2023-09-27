namespace Models.Entities;

public partial class SourceMessage
{
    public int Id { get; set; }

    public string? Category { get; set; }

    public string? Message { get; set; }

    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();
}
