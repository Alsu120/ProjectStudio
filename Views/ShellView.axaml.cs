using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace ProjectStudio.Views;

public partial class ShellView : UserControl
{
    public event EventHandler? LogoutRequested;

    public ShellView()
    {
        InitializeComponent();\
        UserNameText.Text = AppState.FullName;
        NavOverview.IsChecked = true;
        Navigate("Overview");
    }

    private void Nav_Click(object? sender, RoutedEventArgs e)
    {
        if (sender is Control { Tag: string tag })
            Navigate(tag);
    }

    private void Navigate(string tag)
    {
        PageHost.Content = tag switch
        {
            "Projects" => new ProjectsView(),
            "Tasks" => new TasksView(),
            "Calendar" => new CalendarView(),
            "Team" => new TeamView(),
            "Settings" => new SettingsView(),
            "Profile" => new ProfileView(),
            _ => new OverviewView(),
        };
    }

    private void Logout_Click(object? sender, RoutedEventArgs e) =>
        LogoutRequested?.Invoke(this, EventArgs.Empty);
}
