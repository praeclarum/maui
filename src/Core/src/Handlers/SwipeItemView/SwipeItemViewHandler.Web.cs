using System;

namespace Microsoft.Maui.Handlers
{
	public partial class SwipeItemViewHandler : ViewHandler<ISwipeItemView, Ooui.Element>, ISwipeItemViewHandler
	{
		protected override Ooui.Element CreatePlatformView()
		{
			throw new NotImplementedException();
		}

		public static void MapContent(ISwipeItemViewHandler handler, ISwipeItemView page)
		{
		}

		public static void MapVisibility(ISwipeItemViewHandler handler, ISwipeItemView view)
		{
		}
	}
}
