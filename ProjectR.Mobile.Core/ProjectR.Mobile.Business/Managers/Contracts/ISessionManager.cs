using System;
using ProjectR.Mobile.Data;

namespace ProjectR.Mobile.Business
{
	public interface ISessionManager
	{
		void Create (string userName, string password);
		void Destroy ();
		ActiveSessionInfo GetActiveSession ();

		bool isActive { get; }
	}
}

