using System;

namespace Microsoft.Maui.Handlers
{
	public partial class ContentViewHandler : ViewHandler<IContentView, ContentView>
	{
		protected override ContentView CreatePlatformView() =>
			new ContentView("div");

		static void UpdateContent(IContentViewHandler handler)
		{
			_ = handler.PlatformView ?? throw new InvalidOperationException($"{nameof(PlatformView)} should have been set by base class.");
			_ = handler.VirtualView ?? throw new InvalidOperationException($"{nameof(VirtualView)} should have been set by base class.");
			_ = handler.MauiContext ?? throw new InvalidOperationException($"{nameof(MauiContext)} should have been set by base class.");

			// Cleanup the old view when reused
			if (handler.PlatformView.Children.Count > 0)
				handler.PlatformView.RemoveChild(handler.PlatformView.Children[0]);

			if (handler.VirtualView.PresentedContent is IView view)
			{
				var platformView = view.ToPlatform(handler.MauiContext);
				handler.PlatformView.AppendChild(platformView);

				if (view.FlowDirection == FlowDirection.MatchParent)
				{
					platformView.UpdateFlowDirection(view);
				}
			}
		}

		public static void MapContent(IContentViewHandler handler, IContentView page)
		{
			UpdateContent(handler);
		}
	}
}
