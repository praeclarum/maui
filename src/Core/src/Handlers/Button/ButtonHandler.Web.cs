using System;

namespace Microsoft.Maui.Handlers
{
	public partial class ButtonHandler : ViewHandler<IButton, Ooui.Element>
	{
		protected override Ooui.Element CreatePlatformView()
		{
			var button = new Ooui.Button();
			// button.Click += OnClick;
			if (VirtualView is IText text) {
				button.Text = text.Text;
			}
			return button;
		}

		public static void MapStrokeColor(IButtonHandler handler, IButtonStroke buttonStroke) { }
		public static void MapStrokeThickness(IButtonHandler handler, IButtonStroke buttonStroke) { }
		public static void MapCornerRadius(IButtonHandler handler, IButtonStroke buttonStroke) { }
		public static void MapText(IButtonHandler handler, IText button)
		{
			handler.PlatformView.Text = button.Text;
		}
		public static void MapTextColor(IButtonHandler handler, ITextStyle button) { }
		public static void MapCharacterSpacing(IButtonHandler handler, ITextStyle button) { }
		public static void MapFont(IButtonHandler handler, ITextStyle button) { }
		public static void MapPadding(IButtonHandler handler, IButton button) { }
		public static void MapImageSource(IButtonHandler handler, IImage image) { }

		void OnSetImageSource(object? obj) { }
	}
}