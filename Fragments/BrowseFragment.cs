
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;
using ProjectR.Mobile.Business;
using Autofac;

namespace Guild_Android
{
	public class BrowseFragment : Fragment
	{
		private ISynchronizationService _syncService;

		public async override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			//_syncService = AppEnvironment.Container.Resolve<ISessionManager> ();
			// Create your fragment here
			_syncService = new SynchronizationService();
			var data = await _syncService.GetApplicationSchema ();
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			// Use this to return your custom view for this Fragment
			return inflater.Inflate(Resource.Layout.fragment_browse, container, false);
		}
	}
}

