using Avalonia;
using Avalonia.Controls;
using Avalonia.ReactiveUI;
using PiggyBank.ViewModels;
using PiggyBank.Views;
using System;

namespace PiggyBank
{
  internal sealed class Program
  {
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace()
            .UseReactiveUI();

    private static void AppMain(Application app, string[] args)
    {
      var windows = new MainWindow
      {
        DataContext = new MainWindowViewModel(),
      };

      app.Run(windows);
      app.Run(windows);
    }
  }
}
