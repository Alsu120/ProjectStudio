namespace ProjectStudio;

/// <summary>
/// Данные «авторизованного» пользователя (без базы данных).
/// ЗАМЕНИТЕ FullName на своё ФИО!
/// </summary>
public static class AppState
{
    public const string Login = "admin";
    public const string Password = "admin";

    public static string FullName { get; set; } = "Фамилия Имя Отчество";
    public static string Role { get; set; } = "Разработчик";
    public static string Email { get; set; } = "student@projectstudio.local";
    public static string Phone { get; set; } = "+7 (900) 000-00-00";
}
