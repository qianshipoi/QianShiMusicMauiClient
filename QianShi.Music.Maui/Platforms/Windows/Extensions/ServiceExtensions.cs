using Microsoft.Maui.LifecycleEvents;
using Microsoft.TeamFoundation.Common.Internal;
using Microsoft.UI;
using Microsoft.UI.Windowing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Topshelf.Runtime.Windows;

using Windows.Graphics;

namespace QianShi.Music.Maui.Platforms.Windows.Extensions
{
    public static class ServiceExtensions
    {
        public static bool RegisterWinUILifeCycleEvent(this ILifecycleBuilder builder)
        {
            builder.AddWindows(windows =>
            {
                windows.AddWindows(wndLifeCycleBuilder =>
                {
                    wndLifeCycleBuilder.OnWindowCreated(window =>
                    {
                        IntPtr nativeWindowHandle = WinRT.Interop.WindowNative.GetWindowHandle(window);
                        var win32WindowsId = Win32Interop.GetWindowIdFromWindow(nativeWindowHandle);
                        var winuiAppWindow = AppWindow.GetFromWindowId(win32WindowsId);

                        //int width = 1680;
                        //int height = 1000; //1050;
                        //winuiAppWindow.MoveAndResize(new RectInt32(0, 0, width, height));

                        bool fullScreen = true;
                        if (winuiAppWindow is not null)
                        {
                            if (fullScreen)
                            {
                                winuiAppWindow.SetPresenter(AppWindowPresenterKind.FullScreen);
                            }
                            else
                            {
                                winuiAppWindow.SetPresenter(AppWindowPresenterKind.Default);
                            }
                        }
                    });
                });
            });


            return true;
        }

    }
}
