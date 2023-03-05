using System;

namespace Microsoft.Maui.Handlers
{
	public partial class ActivityIndicatorHandler : ViewHandler<IActivityIndicator, Ooui.Element>
	{
		protected override Ooui.Element CreatePlatformView() => throw new NotImplementedException();

		public static void MapIsRunning(IActivityIndicatorHandler handler, IActivityIndicator activityIndicator) { }
		public static void MapColor(IActivityIndicatorHandler handler, IActivityIndicator activityIndicator) { }
	}
}