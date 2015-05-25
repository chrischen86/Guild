using System;

using Android.App;
using Android.Support.V4.App;
using Android.Support.V4.Widget;
using Android.Views;

namespace Guild_Android
{
	public delegate void ActionbarDrawerChangedEventHandler(object s, NavigationDrawerEventArgs e);

	public class ActionbarDrawerToggle : ActionBarDrawerToggle
	{
		public ActionbarDrawerToggle(Activity activity,
			DrawerLayout drawerLayout,
			int drawerImageRes,
			int openDrawerContentDescRes,
			int closeDrawerContentDescRes)
			: base(activity,
				drawerLayout,
				drawerImageRes,
				openDrawerContentDescRes,
				closeDrawerContentDescRes)
		{

		}

		public event ActionbarDrawerChangedEventHandler DrawerClosed;
		public event ActionbarDrawerChangedEventHandler DrawerOpened;
		public event ActionbarDrawerChangedEventHandler DrawerSlide;
		public event ActionbarDrawerChangedEventHandler DrawerStateChanged;

		public override void OnDrawerClosed(View drawerView)
		{
			if (null != this.DrawerClosed)
				this.DrawerClosed(this, new NavigationDrawerEventArgs { DrawerView = drawerView });
			base.OnDrawerClosed(drawerView);
		}

		public override void OnDrawerOpened(View drawerView)
		{
			if (null != this.DrawerOpened)
				this.DrawerOpened(this, new NavigationDrawerEventArgs { DrawerView = drawerView });
			base.OnDrawerOpened(drawerView);
		}

		public override void OnDrawerSlide(View drawerView, float slideOffset)
		{
			if (null != this.DrawerSlide)
				this.DrawerSlide(this, new NavigationDrawerEventArgs
					{
						DrawerView = drawerView,
						SlideOffset = slideOffset
					});
			base.OnDrawerSlide(drawerView, slideOffset);
		}

		public override void OnDrawerStateChanged(int newState)
		{
			if (null != this.DrawerStateChanged)
				this.DrawerStateChanged(this, new NavigationDrawerEventArgs
					{
						NewState = newState
					});
			base.OnDrawerStateChanged(newState);
		}
	}
}