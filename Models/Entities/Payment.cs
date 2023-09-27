namespace Models.Entities;

public partial class Payment
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public int Price { get; set; }

    public string? Items { get; set; }

    /// <summary>
    /// номер обращения к платежной системе
    /// </summary>
    public string? Reference { get; set; }

    /// <summary>
    /// код авторизации
    /// </summary>
    public string? ApprovalCode { get; set; }

    /// <summary>
    /// Страна эмитент карты
    /// </summary>
    public string? CardBin { get; set; }

    public int? Status { get; set; }

    public string? ErrorType { get; set; }

    public string? ModelClass { get; set; }

    public string? ModelId { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }
}
