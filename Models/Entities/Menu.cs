namespace Models.Entities;

public partial class Menu
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public short? IsActive { get; set; }

    public virtual ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
}
