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

namespace QianShi.Music.Maui.Platforms.Windows.Extensions
{
    public static class ServiceExtensions
    {
        public static bool RegisterWinUILifeCycleEvent(this ILifecycleBuilder builder)
        {
            builder.AddWindows(windows =>
            {
                windows.OnWindowCreated(w =>
                {
                    if (w is MauiWinUIWindow windows)
                    {
                        var windowId = Win32Interop.GetWindowIdFromWindow(windows.WindowHandle);
                        var appWindow = AppWindow.GetFromWindowId(windowId);
                        windows.ExtendsContentIntoTitleBar = false;

                        var titleBar = appWindow.TitleBar;
                        titleBar.ExtendsContentIntoTitleBar = true;

                        titleBar.ForegroundColor = Microsoft.UI.Colors.Black;
                        titleBar.BackgroundColor = Microsoft.UI.Colors.Transparent;
                        titleBar.ButtonForegroundColor = Microsoft.UI.Colors.Gray;
                        titleBar.ButtonBackgroundColor = Microsoft.UI.Colors.Transparent;
                        titleBar.ButtonHoverForegroundColor = Microsoft.UI.Colors.Gainsboro;
                        titleBar.ButtonHoverBackgroundColor = Microsoft.UI.Colors.DarkSeaGreen;
                    }
                });
            });


            return true;
        }

    }
}
