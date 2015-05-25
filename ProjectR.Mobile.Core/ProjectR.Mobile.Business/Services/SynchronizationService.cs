using System;
using System.Net.Http;
using Autofac;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Generic;

namespace ProjectR.Mobile.Business
{
	public class SynchronizationService : ISynchronizationService
	{
		public ISessionManager SessionManager { 
			get	{ 
				return AppEnvironment.Container.Resolve<ISessionManager>();
			}
		}

		private readonly string _url = "http://ilx00385.intelex.com/vennprimeapi/vennprime";

		protected HttpClient Client {
			get {
				if (!SessionManager.isActive) {
					throw new Exception ("No Active Session");
				}

				var client = new HttpClient ();
				var activeSession = SessionManager.GetActiveSession ();
				client.DefaultRequestHeaders.Add ("Username", activeSession.Username);
				client.DefaultRequestHeaders.Add ("Password", activeSession.Password);
				return client; 
			}
		}

		public SynchronizationService ()
		{

		}



		#region ISynchronizationService implementation

		public async Task<string> GetApplicationSchema ()
		{
			string result = null;

			try 
			{
				result = await Get("/SchemaService/web/IntelexClubs_AssociationsObject");
			}
			catch (Exception e) {
				Debug.WriteLine (e.Message);
			}

			return result;
		}

		public async Task<string> GetObjectData (string objectName, List<string> fields)
		{
			string result = null;

			try 
			{
				result = await Get("/SchemaService/web/IntelexClubs_AssociationsObject");
			}
			catch (Exception e) {
				Debug.WriteLine (e.Message);
			}

			return result;
		}

		#endregion

		private async Task<string> Get(string uri)
		{
			var client = Client;
			client.BaseAddress = new Uri (_url);

			var response = await client.GetAsync(uri);
			response.EnsureSuccessStatusCode ();

			var result = response.Content.ReadAsStringAsync ().Result;
			return result;
		}

		private async Task<string> Post(string uri)
		{
			var client = Client;
			client.BaseAddress = new Uri (_url);

			var response = await client.PostAsync(uri);
			response.EnsureSuccessStatusCode ();

			var result = response.Content.ReadAsStringAsync ().Result;
			return result;
		}
	}
}