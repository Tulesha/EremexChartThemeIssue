using System.Collections.Generic;
using Avalonia.Styling;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChartThemeIssue.ViewModels;

public partial class DialogWindowViewModel : ViewModelBase
{
    [ObservableProperty] private ThemeVariant _themeVariant;

    public DialogWindowViewModel()
    {
        _themeVariant = ThemeVariant.Default;
    }

    public IEnumerable<ThemeVariant> ThemeVariants { get; } =
        [ThemeVariant.Default, ThemeVariant.Light, ThemeVariant.Dark];
}