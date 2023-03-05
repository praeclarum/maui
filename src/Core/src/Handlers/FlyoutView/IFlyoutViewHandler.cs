#if __IOS__ || MACCATALYST
using PlatformView = UIKit.UIView;
#elif MONOANDROID
using PlatformView = Android.Views.View;
#elif WEB
using PlatformView = Ooui.Element;
#elif WINDOWS
using PlatformView = Microsoft.Maui.Platform.RootNavigationView;
#elif TIZEN
using PlatformView = Tizen.UIExtensions.NUI.DrawerView;
#elif (NETSTANDARD || !PLATFORM) || (NET6_0_OR_GREATER && !IOS && !ANDROID && !WEB)
using PlatformView = System.Object;
#endif

namespace Microsoft.Maui.Handlers
{
	public partial interface IFlyoutViewHandler : IViewHandler
	{
		new IFlyoutView VirtualView { get; }
		new PlatformView PlatformView { get; }
	}
}