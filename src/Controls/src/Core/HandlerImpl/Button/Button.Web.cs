#nullable disable

using Microsoft.Maui.Controls.Platform;

namespace Microsoft.Maui.Controls
{
	public partial class Button
	{
		/// <summary>
		/// Maps the abstract <see cref="Text"/> property to the platform implementation.
		/// </summary>
		/// <param name="handler">The handler associated to this control.</param>
		/// <param name="button">The abstract control that is being mapped.</param>
		public static void MapText(ButtonHandler handler, Button button) =>
			MapText((IButtonHandler)handler, button);

		/// <summary>
		/// Maps the abstract <see cref="LineBreakMode"/> property to the platform implementation.
		/// </summary>
		/// <param name="handler">The handler associated to this control.</param>
		/// <param name="button">The abstract control that is being mapped.</param>
		public static void MapLineBreakMode(ButtonHandler handler, Button button) { }

		public static void MapText(IButtonHandler handler, Button button)
		{
			handler.PlatformView?.UpdateText(button);
		}

		public static void MapLineBreakMode(IButtonHandler handler, Button button) { }
	}
}
