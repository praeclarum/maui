#if __IOS__ || MACCATALYST
using PlatformView = Microsoft.Maui.Platform.ContentView;
#elif MONOANDROID
using PlatformView = Android.Views.View;
#elif WEB
using PlatformView = Ooui.Element;
#elif WINDOWS
using PlatformView = Microsoft.UI.Xaml.Controls.RadioButton;
#elif TIZEN
using PlatformView = Microsoft.Maui.Platform.ContentViewGroup;
#elif (NETSTANDARD || !PLATFORM) || (NET6_0_OR_GREATER && !IOS && !ANDROID && !TIZEN && !WEB)
using PlatformView = System.Object;
#endif

namespace Microsoft.Maui.Handlers
{
	public partial interface IRadioButtonHandler : IViewHandler
	{
		new IRadioButton VirtualView { get; }
		new PlatformView PlatformView { get; }
	}
}