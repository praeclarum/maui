﻿#if __IOS__ || MACCATALYST
using PlatformView = Microsoft.Maui.Platform.MauiRefreshView;
#elif MONOANDROID
using PlatformView = Microsoft.Maui.Platform.MauiSwipeRefreshLayout;
#elif WEB
using PlatformView = Ooui.Element;
#elif WINDOWS
using PlatformView = Microsoft.UI.Xaml.Controls.RefreshContainer;
#elif TIZEN
using PlatformView = Microsoft.Maui.Platform.MauiRefreshLayout;
#elif (NETSTANDARD || !PLATFORM) || (NET6_0_OR_GREATER && !IOS && !ANDROID && !TIZEN && !WEB)
using PlatformView = System.Object;
#endif

namespace Microsoft.Maui.Handlers
{
	public partial interface IRefreshViewHandler : IViewHandler
	{
		new IRefreshView VirtualView { get; }
		new PlatformView PlatformView { get; }
	}
}