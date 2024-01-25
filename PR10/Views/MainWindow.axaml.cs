using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.ReactiveUI;
using PR10.ViewModels;

namespace PR10.Views;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();
        ViewModel = new();
    }

    private void InputElement_OnTapped(object? sender, TappedEventArgs e) {
        if (sender is TextBlock tb) {
            tb.Text = "Пук";
        }
    }
}