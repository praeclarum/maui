﻿#if IOS || MACCATALYST
using PlatformView = UIKit.UINavigationBar;
#elif MONOANDROID
using PlatformView = Google.Android.Material.AppBar.MaterialToolbar;
#elif WEB
using PlatformView = Ooui.Element;
#elif WINDOWS
using PlatformView = Microsoft.Maui.Platform.MauiToolbar;
#elif TIZEN
using PlatformView = Microsoft.Maui.Platform.MauiToolbar;
#elif (NETSTANDARD || !PLATFORM) || (NET6_0_OR_GREATER && !IOS && !ANDROID && !TIZEN && !WEB)
using PlatformView = System.Object;
#endif

namespace Microsoft.Maui.Handlers
{
	public partial class ToolbarHandler : IToolbarHandler
	{
		public static IPropertyMapper<IToolbar, IToolbarHandler> Mapper =
			   new PropertyMapper<IToolbar, IToolbarHandler>(ElementMapper)
			   {
				   [nameof(IToolbar.Title)] = MapTitle,
			   };

		public static CommandMapper<IToolbar, IToolbarHandler> CommandMapper = new();

		public ToolbarHandler() : base(Mapper, CommandMapper)
		{
		}

		public ToolbarHandler(IPropertyMapper? mapper)
			: base(mapper ?? Mapper, CommandMapper)
		{
		}

		public ToolbarHandler(IPropertyMapper? mapper, CommandMapper? commandMapper)
			: base(mapper ?? Mapper, commandMapper ?? CommandMapper)
		{
		}

		IToolbar IToolbarHandler.VirtualView => VirtualView;
		PlatformView IToolbarHandler.PlatformView => PlatformView;
	}
}
