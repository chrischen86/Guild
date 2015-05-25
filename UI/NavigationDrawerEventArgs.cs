using System;
using Android.Views;

namespace Guild_Android
{
	public class NavigationDrawerEventArgs
	{
		public View DrawerView { get; set; }
		public float SlideOffset { get; set; }
		public int NewState { get; set; }
	}
}