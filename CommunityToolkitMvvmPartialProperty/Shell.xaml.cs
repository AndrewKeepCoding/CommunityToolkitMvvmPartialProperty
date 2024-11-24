using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml.Controls;

namespace CommunityToolkitMvvmPartialProperty;

public partial class SomeViewModel : ObservableObject
{
    //[ObservableProperty]
    //private string? _someText;

    [ObservableProperty]
    public partial string? SomeText { get; private set; }
}

public sealed partial class Shell : Page
{
    public Shell()
    {
        InitializeComponent();
    }

    public SomeViewModel ViewModel { get; } = new();
}
