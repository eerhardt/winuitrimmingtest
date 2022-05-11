using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WinRT.Interop;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TrimmedWinUIApp
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            // The following GetWindowHandle call results in this exception when PublishTrimmed=true:

            // System.NotSupportedException
            // HResult = 0x80131515
            // Message = Built -in COM has been disabled via a feature switch.See https://aka.ms/dotnet-illink/com for more information.
            // Source = System.Private.CoreLib
            // StackTrace:
            //  at System.Private.CoreLib.dll!System.Runtime.InteropServices.Marshal.GetObjectForIUnknown(System.IntPtr value) Unknown
            //  at WinRT.Runtime.dll!WinRT.IObjectReference.AsInterface<WinRT.Interop.IWindowNative>() Unknown
            //  at WinRT.Runtime.dll!WinRT.CastExtensions.As<WinRT.Interop.IWindowNative>(object value)    Unknown
            //  at Microsoft.Windows.SDK.NET.dll!WinRT.Interop.WindowNative.GetWindowHandle(object target) Unknown

            myButton.Content = $"Clicked. Windows Handle: {WindowNative.GetWindowHandle(this)}";
        }
    }
}
