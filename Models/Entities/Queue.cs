namespace Models.Entities;

public partial class Queue
{
    public int Id { get; set; }

    public string Channel { get; set; } = null!;

    public byte[] Job { get; set; } = null!;

    public int PushedAt { get; set; }

    public int Ttr { get; set; }

    public int Delay { get; set; }

    public uint Priority { get; set; }

    public int? ReservedAt { get; set; }

    public int? Attempt { get; set; }

    public int? DoneAt { get; set; }
}
