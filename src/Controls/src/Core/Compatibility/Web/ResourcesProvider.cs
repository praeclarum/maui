#nullable disable
using System;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Graphics;

namespace Microsoft.Maui.Controls.Compatibility.Platform.Web
{
	[Obsolete]
	internal class ResourcesProvider : ISystemResourcesProvider
	{
		ResourceDictionary _dictionary;

		public IResourceDictionary GetSystemResources()
		{
			_dictionary = new ResourceDictionary();

			return _dictionary;
		}
	}
}
