namespace Models.Entities;

public partial class ProductsSuggest
{
    public int ProductId { get; set; }

    public int SuggestProductId { get; set; }

    public virtual Product Product { get; set; } = null!;
}
