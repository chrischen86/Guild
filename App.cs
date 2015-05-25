using System;
using System.ComponentModel;
using System.IO;
using Android.App;
using Android.Runtime;
using ProjectR.Mobile.Business;
using ProjectR.Mobile.GuildShared;
using SQLite;

namespace Guild_Android
{
	[Application(Icon="@drawable/icon", Label="@string/app_name")]
	public class App : Application
	{
		public static App Current { get; private set; }
		public GuildManager TaskMgr { get; set; }

		SQLiteConnection conn;

		public App(IntPtr h, JniHandleOwnership jho) : base(h, jho)
		{
			Current = this;
		}

		public override void OnCreate()
		{	
			base.OnCreate ();

			var bootstrapper = new Bootstrapper(this);
			bootstrapper.Run();

			var sqliteFilename = "GuildDB.db3";
			string libraryPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var path = Path.Combine(libraryPath, sqliteFilename);
			conn = new SQLiteConnection (path);

			TaskMgr = new GuildManager(conn);
		}
	}
}

