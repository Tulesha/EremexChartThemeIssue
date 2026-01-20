using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ChartThemeIssue.ViewModels;

namespace ChartThemeIssue.Views;

public partial class DialogWindow : Window
{
    public DialogWindow()
    {
        InitializeComponent();
    }
    
    public DialogWindow(DialogWindowViewModel vm): this()
    {
        DataContext = vm;
    }
}