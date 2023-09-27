namespace Models.Entities;

public partial class Migration
{
    public string Version { get; set; } = null!;

    public int? ApplyTime { get; set; }
}
