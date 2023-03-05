namespace Microsoft.Maui
{
	public interface IPlatformViewHandler : IViewHandler
	{
		new Ooui.Element? PlatformView { get; }
		new Ooui.Element? ContainerView { get; }
	}
}