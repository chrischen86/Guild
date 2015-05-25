using System;
using Android.App;
using Android.Support.V4.Widget;
using Android.Support.V7.Widget;
using Android.Views;

namespace Guild_Android
{
	public delegate void ToolbarDrawerChangedEventHandler(object s, NavigationDrawerEventArgs e);

	public class ToolbarDrawerToggle :  Android.Support.V7.App.ActionBarDrawerToggle
	{
		public ToolbarDrawerToggle(Activity activity,
			DrawerLayout drawerLayout,
			int openDrawerContentDescRes,
			int closeDrawerContentDescRes)
			: base(activity,
				drawerLayout,
				openDrawerContentDescRes,
				closeDrawerContentDescRes)
		{

		}

		public ToolbarDrawerToggle(Activity activity,
			DrawerLayout drawerLayout,
			Toolbar toolbar,
			int openDrawerContentDescRes,
			int closeDrawerContentDescRes)
			: base(activity,
				drawerLayout,
				toolbar,
				openDrawerContentDescRes,
				closeDrawerContentDescRes)
		{

		}

		public event ToolbarDrawerChangedEventHandler DrawerClosed;
		public event ToolbarDrawerChangedEventHandler DrawerOpened;
		public event ToolbarDrawerChangedEventHandler DrawerSlide;
		public event ToolbarDrawerChangedEventHandler DrawerStateChanged;

		public override void OnDrawerClosed(View drawerView)
		{
			if (DrawerClosed != null) {
				DrawerClosed (this, new NavigationDrawerEventArgs { DrawerView = drawerView });
			}

			base.OnDrawerClosed(drawerView);
		}

		public override void OnDrawerOpened(View drawerView)
		{
			if (DrawerOpened != null) {
				DrawerOpened (this, new NavigationDrawerEventArgs { DrawerView = drawerView });
			}

			base.OnDrawerOpened(drawerView);
		}

		public override void OnDrawerSlide(View drawerView, float slideOffset)
		{
			if (DrawerSlide != null) {
				DrawerSlide (this, new NavigationDrawerEventArgs {
					DrawerView = drawerView,
					SlideOffset = slideOffset
				});
			}
			base.OnDrawerSlide(drawerView, slideOffset);
		}

		public override void OnDrawerStateChanged(int newState)
		{
			if (DrawerStateChanged != null) {
				DrawerStateChanged (this, new NavigationDrawerEventArgs {
					NewState = newState
				});
			}
			base.OnDrawerStateChanged(newState);
		}
	}
}