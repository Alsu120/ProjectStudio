using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace ProjectStudio.Views;

public partial class LoginView : UserControl
{
    public event EventHandler? LoginSucceeded;

    public LoginView() => InitializeComponent();

    private void Login_Click(object? sender, RoutedEventArgs e)
    {
        var ok = LoginBox.Text?.Trim() == AppState.Login && PasswordBox.Text == AppState.Password;

        if (ok)
        {
            ErrorText.IsVisible = false;
            LoginSucceeded?.Invoke(this, EventArgs.Empty);
        }
        else
        {
            ErrorText.Text = "Неверный логин или пароль";
            ErrorText.IsVisible = true;
        }
    }
}
