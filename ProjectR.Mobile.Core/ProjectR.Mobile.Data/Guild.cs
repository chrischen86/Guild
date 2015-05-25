using System;
using SQLite;

namespace ProjectR.Mobile.Data
{
	public class Guild : IBusinessEntity
	{
		public Guild ()
		{
		}

		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }

		public string Name { get; set; }
		public string Description { get; set; }	
	}
}

