using System;

namespace Microsoft.Maui.Handlers
{
	public partial class ToolbarHandler : ElementHandler<IToolbar, Ooui.Element>
	{
		protected override Ooui.Element CreatePlatformElement() => throw new NotImplementedException();

		public static void MapTitle(IToolbarHandler arg1, IToolbar arg2)
		{
		}
	}
}