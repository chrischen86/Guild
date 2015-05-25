using System;
using ProjectR.Mobile.Dal;
using ProjectR.Mobile.Data;
using System.Collections.Generic;
using SQLite;

namespace ProjectR.Mobile.Business
{
	public class GuildManager
	{
		GuildRepository repository;

		public GuildManager (SQLiteConnection conn) 
		{
			repository = new GuildRepository(conn, "");
		}

		public Guild GetGuild(int id)
		{
			return repository.GetGuild(id);
		}

		public IList<Guild> GetGuilds ()
		{
			return new List<Guild>(repository.GetGuilds());
		}
	}
}

