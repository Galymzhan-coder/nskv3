namespace Models.Entities;

public partial class UsersAuth
{
    public int Id { get; set; }

    /// <summary>
    /// Пользователь
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Токен авторизации
    /// </summary>
    public string Token { get; set; } = null!;

    /// <summary>
    /// Срок действия токена
    /// </summary>
    public DateTime ExpireDate { get; set; }

    public DateTime CreateDate { get; set; }
}
