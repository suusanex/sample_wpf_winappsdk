using Microsoft.Windows.ApplicationModel.DynamicDependency;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWPFWinAppSDK
{
    internal class Program
    {

        // NOTE We can't make Main async in a WPF app.
        //[STAThread]
        //public static int Main(string[] args)
        //{
        //    // Initialize Windows App SDK for unpackaged apps.            
        //    int result = 0;
        //    if (Bootstrap.TryInitialize(majorMinorVersion, out result))
        //    {
        //        bool isRedirect = DecideRedirection();
        //        if (!isRedirect)
        //        {
        //            App app = new()
        //            {
        //                StartupUri = new Uri("MainWindow.xaml", UriKind.Relative)
        //            };
        //            app.Run();
        //        }

        //        // Uninitialize Windows App SDK.
        //        Bootstrap.Shutdown();
        //    }
        //    return 0;
        //}
    }
}
