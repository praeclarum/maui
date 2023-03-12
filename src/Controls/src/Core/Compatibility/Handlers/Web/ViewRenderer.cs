using System;
using System.Collections.Generic;
using System.Text;
using PlatformView = Ooui.Element;

namespace Microsoft.Maui.Controls.Handlers.Compatibility
{
	public abstract partial class ViewRenderer<TElement, TNativeView> : VisualElementRenderer<TElement>, IPlatformViewHandler
		where TElement : View, IView
		where TNativeView : PlatformView
	{
		public ViewRenderer(string tagName) : base(tagName)
        {
        }
	}
}