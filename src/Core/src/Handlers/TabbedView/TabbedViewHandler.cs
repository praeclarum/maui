﻿using System;
using System.Collections.Generic;
using System.Text;
#if IOS || MACCATALYST
using PlatformView = UIKit.UIView;
#elif MONOANDROID
using PlatformView = Android.Views.View;
#elif WINDOWS
using PlatformView = Microsoft.UI.Xaml.FrameworkElement;
#elif TIZEN
using PlatformView = ElmSharp.EvasObject;
#elif WEB
using PlatformView = Microsoft.AspNetCore.Components.ComponentBase;
#elif (NETSTANDARD || !PLATFORM) || (NET6_0_OR_GREATER && !IOS && !ANDROID && !TIZEN && !WEB)
using PlatformView = System.Object;
#endif

namespace Microsoft.Maui.Handlers
{
	public partial class TabbedViewHandler : ViewHandler<ITabbedView, PlatformView>, ITabbedViewHandler
	{
		public static IPropertyMapper<ITabbedView, ITabbedViewHandler> Mapper = new PropertyMapper<ITabbedView, ITabbedViewHandler>(ViewHandler.ViewMapper);

		public static CommandMapper<ITabbedView, ITabbedViewHandler> CommandMapper = new(ViewCommandMapper);

		public TabbedViewHandler() : base(Mapper, CommandMapper)
		{
		}

		protected override PlatformView CreatePlatformView()
		{
			throw new NotImplementedException();
		}
	}
}
