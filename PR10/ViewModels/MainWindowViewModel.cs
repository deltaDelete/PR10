using System.Linq;
using Avalonia.Collections;
using PR10.Database;

namespace PR10.ViewModels;

public class MainWindowViewModel : ViewModelBase {
#pragma warning disable CA1822 // Mark members as static
    public string Greeting => "Welcome to Avalonia!";
#pragma warning restore CA1822 // Mark members as static
    public AvaloniaList<User> Users { get; private set; } = new(new AppDb().Users.ToList());
}