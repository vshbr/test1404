using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using test1404.Models;

namespace test1404;

public partial class WindowPanel : Window
{
    public WindowPanel()
    {
    }

    public WindowPanel(Models.Phone partner)
    {
        InitializeComponent();
    }

    private void Button(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        Close();

    }
}