#nullable disable
using System;
using Microsoft.Maui.Controls.Internals;
using static Microsoft.Maui.Controls.Button;

namespace Microsoft.Maui.Controls.Platform
{
	public static class ButtonExtensions
	{
		public static void UpdateContentLayout(this Ooui.Element platformButton, Button button)
		{
		}

        public static void UpdateText(this Ooui.Element element, Button button)
		{
            element.Text = button.Text;
        }
	}
}
