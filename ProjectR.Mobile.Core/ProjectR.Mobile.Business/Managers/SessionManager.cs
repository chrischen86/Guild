using System;
using ProjectR.Mobile.Data;

namespace ProjectR.Mobile.Business
{
	public class SessionManager : ISessionManager
	{
		public SessionManager ()
		{
		}

		#region ISessionManager implementation

		public void Create (string userName, string password)
		{
			throw new NotImplementedException ();
		}

		public void Destroy ()
		{
			throw new NotImplementedException ();
		}

		public ActiveSessionInfo GetActiveSession ()
		{
			return new ActiveSessionInfo { 
				Username = @"INTELEX\Administrator",
				Password = @"asAS12!@padding",
			};
		}

		public bool isActive {
			get {
				return true;
			}
		}

		#endregion
	}
}

