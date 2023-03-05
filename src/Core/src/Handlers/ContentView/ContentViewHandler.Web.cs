using System;

namespace Microsoft.Maui.Handlers
{
	public partial class ContentViewHandler : ViewHandler<IContentView, Ooui.Element>
	{
		protected override Ooui.Element CreatePlatformView() => throw new NotImplementedException();

		public static void MapContent(IContentViewHandler handler, IContentView page)
		{
		}
	}
}
