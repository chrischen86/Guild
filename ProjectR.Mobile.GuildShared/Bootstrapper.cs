using System;
using ProjectR.Mobile.Business;
using Autofac;
using Guild_Android;

namespace ProjectR.Mobile.GuildShared
{
	public class Bootstrapper : AutofacBootstrapper
	{
		private App _app;

		public Bootstrapper (App application)
		{
			_app = application;
		}

		#region implemented abstract members of AutofacBootstrapper

		protected override void ConfigureApplication (IContainer container)
		{
			//AppEnvironment.Container = container;
		}

		#endregion


		public void TestFunction()
		{
		}
	}
}

