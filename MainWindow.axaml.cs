using Avalonia.Controls;
using System.Collections.Generic;
using Avalonia.Markup.Xaml;
using System.Linq;
using test1404;
using System.Threading.Tasks;
using test1404.Models;

namespace test1404;

public partial class MainWindow : Window
{
    public List<Phone> phones = Helper.User017Context.Phones.ToList();
    public MainWindow()
    {
        InitializeComponent();
        PartnerListBox.ItemsSource = phones;
    }


    private void Button_Click_Add(object? sender, Avalonia.Interactivity.RoutedEventArgs e) 
    { 
        WindowPanel windowPanel = new WindowPanel();
        windowPanel.Show(); 
        Close(); 
    }
    private void ListBox_DoubleTapped(object? sender, Avalonia.Input.TappedEventArgs e) 
    { 
        var partner = PartnerListBox.SelectedItem as Phone; 
        if (partner != null) 
        { 
            WindowPanel windowPanel = new WindowPanel(partner);
            windowPanel.Show(); 
            Close(); 
        } 
    
    }
    private void Button_Click_History(object? sender, Avalonia.Interactivity.RoutedEventArgs e) 
    { 
        var partner = PartnerListBox.SelectedItem as Phone; 
        if (partner != null) 
        {
            WindowPanel windowPanel = new WindowPanel(partner);
            windowPanel.ShowDialog(this); 
        } 
    }
}