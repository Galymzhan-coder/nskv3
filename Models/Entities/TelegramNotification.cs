namespace Models.Entities;

public partial class TelegramNotification
{
    public int Id { get; set; }

    public string? Chat { get; set; }

    public string? Text { get; set; }

    public string? File { get; set; }

    public int? Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
