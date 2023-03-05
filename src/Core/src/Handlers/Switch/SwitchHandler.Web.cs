using System;

namespace Microsoft.Maui.Handlers
{
	public partial class SwitchHandler : ViewHandler<ISwitch, Ooui.Element>
	{
		protected override Ooui.Element CreatePlatformView() => throw new NotImplementedException();

		public static void MapIsOn(ISwitchHandler handler, ISwitch view) { }
		public static void MapTrackColor(ISwitchHandler handler, ISwitch view) { }
		public static void MapThumbColor(ISwitchHandler handler, ISwitch view) { }
	}
}