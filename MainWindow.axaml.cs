using Avalonia.Controls;
using ProjectStudio.Views;

namespace ProjectStudio;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        ShowLogin();
    }

    private void ShowLogin()
    {
        var login = new LoginView();
        login.LoginSucceeded += (_, _) => ShowShell();
        Host.Content = login;
    }

    private void ShowShell()
    {
        var shell = new ShellView();
        shell.LogoutRequested += (_, _) => ShowLogin();
        Host.Content = shell;
    }
}
