using System;

namespace Microsoft.Maui.Handlers
{
	public partial class ButtonHandler : ViewHandler<IButton, Ooui.Element>
	{
		protected override Ooui.Element CreatePlatformView()
		{
			var button = new Ooui.Button();
			return button;
		}

		protected override void ConnectHandler(Ooui.Element platformView)
		{
			platformView.Click += OnClick;
			platformView.PropertyChanged += (sender, e) => {
				ViewMapper.UpdateProperty(this, VirtualView, e.PropertyName);
			};
			base.ConnectHandler(platformView);
		}

		protected override void DisconnectHandler(Ooui.Element platformView)
		{
			platformView.Click -= OnClick;
			base.DisconnectHandler(platformView);
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

		void OnClick(object? sender, Ooui.TargetEventArgs e)
		{
			VirtualView?.Clicked();			
		}
	}
}