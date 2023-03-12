using System;
using System.ComponentModel;
using Microsoft.Maui.Controls.Platform;
using Microsoft.Maui.Graphics;

namespace Microsoft.Maui.Controls.Handlers.Compatibility
{
	public abstract partial class VisualElementRenderer<TElement> : Ooui.Element, IPlatformViewHandler, IElementHandler
		where TElement : Element, IView
	{
     	object? IElementHandler.PlatformView => throw new NotImplementedException();
        Ooui.Element? IPlatformViewHandler.PlatformView => throw new NotImplementedException();

		object? IViewHandler.ContainerView => throw new NotImplementedException();
        Ooui.Element? IPlatformViewHandler.ContainerView => throw new NotImplementedException();
		
        IElement? IElementHandler.VirtualView => throw new NotImplementedException();
        IView? IViewHandler.VirtualView => throw new NotImplementedException();

        public bool HasContainer { get; set; }

        public VisualElementRenderer(string tagName) : base(tagName)
        {
        }

		public Size GetDesiredSize(double widthConstraint, double heightConstraint)
            => throw new NotImplementedException();

		public void PlatformArrange(Rect frame)
            => throw new NotImplementedException();

        public void SetMauiContext(IMauiContext mauiContext)
            => throw new NotImplementedException();

		public void SetVirtualView(IElement view)
            => throw new NotImplementedException();

		public void UpdateValue(string property)
            => throw new NotImplementedException();

		public void Invoke(string command, object? args = null)
            => throw new NotImplementedException();
		public void DisconnectHandler()
            => throw new NotImplementedException();
		public IMauiContext? MauiContext { get; set; }
	}
}
