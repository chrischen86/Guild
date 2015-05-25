using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ProjectR.Mobile.Business
{
	public interface ISynchronizationService
	{
		Task<string> GetApplicationSchema();
		Task<string> GetObjectData(string objectName, List<string> fields);
	}
}