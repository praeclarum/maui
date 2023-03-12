using System;

namespace Microsoft.Maui.Handlers
{
	public partial class WindowHandler : ElementHandler<IWindow, Ooui.Element>
	{
		public static void MapTitle(IWindowHandler handler, IWindow window) { }

		public static void MapX(IWindowHandler handler, IWindow view) { }

		public static void MapY(IWindowHandler handler, IWindow view) { }

		public static void MapWidth(IWindowHandler handler, IWindow view) { }

		public static void MapHeight(IWindowHandler handler, IWindow view) { }

		public static void MapContent(IWindowHandler handler, IWindow window)
		{
			var nativeContent = window.Content.ToElement(handler.MauiContext);

			var windowElement = handler.PlatformView;
			if (windowElement.Children.Count > 0)
				windowElement.RemoveChild(windowElement.Children[0]);
			handler.PlatformView.AppendChild(nativeContent);

			if (window.VisualDiagnosticsOverlay != null)
				window.VisualDiagnosticsOverlay.Initialize();
		}

		public static void MapRequestDisplayDensity(IWindowHandler handler, IWindow window, object? args) { }
	}
}
