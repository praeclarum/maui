using System;

namespace Microsoft.Maui.Handlers
{
	public partial class ImageButtonHandler : ViewHandler<IImageButton, Microsoft.AspNetCore.Components.ComponentBase>
	{
		protected override Microsoft.AspNetCore.Components.ComponentBase CreatePlatformView() => throw new NotImplementedException();

		public static void MapStrokeColor(IImageButtonHandler handler, IButtonStroke buttonStroke) { }
		public static void MapStrokeThickness(IImageButtonHandler handler, IButtonStroke buttonStroke) { }
		public static void MapCornerRadius(IImageButtonHandler handler, IButtonStroke buttonStroke) { }
		public static void MapPadding(IImageButtonHandler handler, IImageButton imageButton) { }

		void OnSetImageSource(object? obj)
		{
			throw new NotImplementedException();
		}
	}
}