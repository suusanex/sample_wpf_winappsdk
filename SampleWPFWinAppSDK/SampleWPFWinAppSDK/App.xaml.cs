using Microsoft.Windows.AppLifecycle;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Windows;

namespace SampleWPFWinAppSDK
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {
            AppActivationArguments args = AppInstance.GetCurrent().GetActivatedEventArgs();
            Trace.WriteLine($"{args.Kind}");
            var instances = AppInstance.GetInstances();
            Trace.WriteLine($"Count={instances.Count}");
            foreach (var instance in instances)
            {
                Trace.WriteLine($"{instance.GetActivatedEventArgs().Kind}");
            }

            if (1 < instances.Count)
            {
                var mainInstance = instances.First();
                mainInstance.RedirectActivationToAsync(args).GetAwaiter().GetResult();


                // If there is more than one instance, then we have to close this one.
                // The other instance will handle the activation.
                Shutdown();
                return;
            }

            AppInstance.GetCurrent().Activated += OnActivated;

        }

        private void OnActivated(object? sender, AppActivationArguments e)
        {
            Trace.WriteLine($"OnActivated, {e}");
            Current.Dispatcher.Invoke(() => Current.MainWindow?.Activate());
        }
    }

}
