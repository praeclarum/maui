using System;

namespace Microsoft.Maui.Platform
{
	public static partial class ElementExtensions
	{
		public static Ooui.Element ToElement(this IElement view, IMauiContext context)
		{
			var platformView = view.ToPlatform(context);
			return platformView;
		}
	}
}
