﻿using System;

namespace Microsoft.Maui.Handlers
{
	public partial class NavigationViewHandler : ViewHandler<IStackNavigationView, Ooui.Element>
	{
		protected override Ooui.Element CreatePlatformView()
		{
			throw new NotImplementedException();
		}

		public static void RequestNavigation(INavigationViewHandler arg1, IStackNavigation arg2, object? arg3)
		{
			throw new NotImplementedException();
		}
	}
}
