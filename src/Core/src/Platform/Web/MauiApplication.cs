using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.LifecycleEvents;
using IOPath = System.IO.Path;

namespace Microsoft.Maui
{
	public abstract class MauiApplication : IPlatformApplication
	{
		public IServiceProvider Services { get; protected set; } = null!;

		public IApplication Application { get; protected set; } = null!;

		protected abstract MauiApp CreateMauiApp();
		public void Run()
		{
			IPlatformApplication.Current = this;
			var mauiApp = CreateMauiApp();

			var rootContext = new MauiContext(mauiApp.Services);

			var applicationContext = rootContext.MakeApplicationScope(this);

			Services = applicationContext.Services;

			// Services.InvokeLifecycleEvents<WebLifecycle.OnLaunching>(del => del(this, args));

			Application = Services.GetRequiredService<IApplication>();

			this.SetApplicationHandler(Application, applicationContext);

            var oouiWindow = new Ooui.Div();
            var mauiContext = applicationContext.MakeWindowScope(oouiWindow, out var windowScope);
			applicationContext.Services.InvokeLifecycleEvents<WebLifecycle.OnMauiContextCreated>(del => del(mauiContext));

			var activationState = new ActivationState(mauiContext);
			var window = Application.CreateWindow(activationState);

			oouiWindow.SetWindowHandler(window, mauiContext);

			Ooui.UI.Publish ("/", oouiWindow);

            Console.ReadLine ();

			// Services.InvokeLifecycleEvents<WebLifecycle.OnLaunched>(del => del(this, args));
		}
	}
}
