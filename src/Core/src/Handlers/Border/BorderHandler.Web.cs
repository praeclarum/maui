using System;

namespace Microsoft.Maui.Handlers
{
	public partial class BorderHandler : ViewHandler<IBorderView, Ooui.Element>
	{
		protected override Ooui.Element CreatePlatformView() => throw new NotImplementedException();

		public static void MapContent(IBorderHandler handler, IBorderView border)
		{
		}
	}
}
