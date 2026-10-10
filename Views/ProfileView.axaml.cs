using Avalonia.Controls;
using System;
using System.Linq;

namespace ProjectStudio.Views;

public partial class ProfileView : UserControl
{
    public ProfileView()
    {
        InitializeComponent();

        FullNameText.Text = AppState.FullName;
        FullNameBox.Text = AppState.FullName;
        RoleText.Text = AppState.Role;
        RoleBox.Text = AppState.Role;
        EmailBox.Text = AppState.Email;
        PhoneBox.Text = AppState.Phone;

        var parts = AppState.FullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        InitialsText.Text = string.Concat(parts.Take(2).Select(p => char.ToUpper(p[0])));
    }
}
