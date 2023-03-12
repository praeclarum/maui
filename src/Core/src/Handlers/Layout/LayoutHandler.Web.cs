using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Maui.Handlers
{
	public partial class LayoutHandler : ViewHandler<ILayout, Ooui.Element>
	{
		public void Add(IView view) => throw new NotImplementedException();
		public void Remove(IView view) => throw new NotImplementedException();
		public void Clear() => throw new NotImplementedException();
		public void Insert(int index, IView view) => throw new NotImplementedException();
		public void Update(int index, IView view) => throw new NotImplementedException();
		public void UpdateZIndex(IView view) => throw new NotImplementedException();

		public override void SetVirtualView(IView view)
		{
			base.SetVirtualView(view);

			var oldChildren = PlatformView.Children.ToArray();
			foreach (var child in oldChildren)
			{
				PlatformView.RemoveChild(child);
			}
			foreach (var child in VirtualView.OrderByZIndex())
			{
				PlatformView.AppendChild(child.ToPlatform(MauiContext));
			}
		}

		protected override Ooui.Element CreatePlatformView()
		{
			return new Ooui.Div();
		}
	}
}
