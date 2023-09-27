namespace Models.Entities;

public partial class PaymentLog
{
    public int Id { get; set; }

    public string? Log { get; set; }

    public DateTime CreateDate { get; set; }

    /// <summary>
    /// Payment ID
    /// </summary>
    public string? PaymentId { get; set; }
}
