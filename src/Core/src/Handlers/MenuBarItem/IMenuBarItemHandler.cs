﻿#if IOS || MACCATALYST
using PlatformView = UIKit.UIMenu;
#elif MONOANDROID
using PlatformView = Android.Views.View;
#elif WEB
using PlatformView = Ooui.Element;
#elif WINDOWS
using PlatformView = Microsoft.UI.Xaml.Controls.MenuBarItem;
#elif TIZEN
using PlatformView = Tizen.NUI.BaseComponents.View;
#elif (NETSTANDARD || !PLATFORM) || (NET6_0_OR_GREATER && !IOS && !ANDROID && !TIZEN && !WEB)
using PlatformView = System.Object;
#endif

namespace Microsoft.Maui.Handlers
{
	public interface IMenuBarItemHandler : IElementHandler
	{
		void Add(IMenuElement view);
		void Remove(IMenuElement view);
		void Clear();
		void Insert(int index, IMenuElement view);
		new PlatformView PlatformView { get; }
		new IMenuBarItem VirtualView { get; }
	}
}
