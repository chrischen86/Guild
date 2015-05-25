using System;
using Autofac;

namespace ProjectR.Mobile.Business
{
	public class AutofacModule : Module
	{
		protected override void Load (ContainerBuilder builder)
		{
			// service registration
			builder.RegisterType<SessionManager> ()
				.As<ISessionManager> ()
				.SingleInstance ();

			//builder.RegisterInstance<ISynchronizationService> (new SynchronizationService ());

//			builder.RegisterInstance(new SessionManager()).As<ISessionManager>();
//			builder.RegisterInstance(new SynchronizationService()).As<ISynchronizationService>();

			//builder.Register<Func<ISessionManager>> (c => () => new SessionManager ());
			//builder.Register<Func<ISynchronizationService>> (c => () => new SynchronizationService ());
		}
	}
}

