using System;
using Autofac;

namespace ProjectR.Mobile.Business
{
	public abstract class AutofacBootstrapper
	{
		public void Run()
		{
			var builder = new ContainerBuilder();
			ConfigureContainer(builder);
			var container = builder.Build();
//			var viewFactory = container.Resolve<IViewFactory>();
//			RegisterViews(viewFactory);
			ConfigureApplication(container);

			AppEnvironment.Container = container;
		}

		protected virtual void ConfigureContainer(ContainerBuilder builder)
		{
			builder.RegisterModule<AutofacModule>();
		}

//		protected abstract void RegisterViews(IViewFactory viewFactory);

		protected abstract void ConfigureApplication(IContainer container);
	}
}

