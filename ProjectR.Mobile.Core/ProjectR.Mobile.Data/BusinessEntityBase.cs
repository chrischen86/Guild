using System;
using SQLite;

namespace ProjectR.Mobile.Data
{
	public class BusinessEntityBase
	{
		public BusinessEntityBase ()
		{
		}

		/// <summary>
		/// Gets or sets the Database ID.
		/// </summary>
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
	}
}

