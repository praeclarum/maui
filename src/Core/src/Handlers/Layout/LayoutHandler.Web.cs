using System;
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

		protected override Ooui.Element CreatePlatformView() => throw new NotImplementedException();
	}
}
