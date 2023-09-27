namespace Models.Entities;

public partial class PushNotification
{
    public int Id { get; set; }

    public int? ClientId { get; set; }

    public ulong DocId { get; set; }

    public short? IsSend { get; set; }

    /// <summary>
    /// Сообщение
    /// </summary>
    public string Message { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
