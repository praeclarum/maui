#if __IOS__ || MACCATALYST
using PlatformView = Microsoft.Maui.Platform.MauiPageControl;
#elif MONOANDROID
using PlatformView = Microsoft.Maui.Platform.MauiPageControl;
#elif WEB
using PlatformView = Ooui.Element;
#elif WINDOWS
using PlatformView = Microsoft.Maui.Platform.MauiPageControl;
#elif TIZEN
using PlatformView = Microsoft.Maui.Platform.MauiPageControl;
#elif (NETSTANDARD || !PLATFORM) || (NET6_0_OR_GREATER && !IOS && !ANDROID && !TIZEN && !WEB)
using PlatformView = System.Object;
#endif

namespace Microsoft.Maui.Handlers
{
	public partial interface IIndicatorViewHandler : IViewHandler
	{
		new IIndicatorView VirtualView { get; }
		new PlatformView PlatformView { get; }
	}
}