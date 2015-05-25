using System;
using ProjectR.Mobile.Data;
using System.Collections.Generic;
using SQLite;

namespace ProjectR.Mobile.Dal
{
	public class GuildRepository
	{
		GuildDatabase db = null;

		public GuildRepository (SQLiteConnection conn, string dbLocation)
		{
			db = new GuildDatabase(conn, dbLocation);
		}

		public Guild GetGuild(int id)
		{
			return db.GetItem<Guild> (id);
		}

		public IEnumerable<Guild> GetGuilds ()
		{
			return db.GetItems<Guild>();
		}
	}
}

