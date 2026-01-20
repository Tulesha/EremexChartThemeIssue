using System.Collections.Generic;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Styling;
using ChartThemeIssue.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ChartThemeIssue.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private ThemeVariant _themeVariant;

    public MainWindowViewModel()
    {
        _themeVariant = Application.Current?.RequestedThemeVariant ?? ThemeVariant.Default;
    }

    public IEnumerable<ThemeVariant> ThemeVariants { get; } =
        [ThemeVariant.Default, ThemeVariant.Light, ThemeVariant.Dark];

    [RelayCommand]
    private async Task ShowDialogWindow(Window window)
    {
        var dialogWindowViewModel = new DialogWindowViewModel();
        var dialogWindow = new DialogWindow(dialogWindowViewModel);

        await dialogWindow.ShowDialog(window);
    }

    partial void OnThemeVariantChanged(ThemeVariant value)
    {
        if (Application.Current != null)
            Application.Current.RequestedThemeVariant = value;
    }
}