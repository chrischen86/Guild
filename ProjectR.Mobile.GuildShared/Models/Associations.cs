using System;

namespace ProjectR.Mobile.GuildShared
{
	public class Associations
	{
		public Guid Id { get; set; }

		public Guid CreatedById { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public string Type { get; set; }

		public int Memberscount { get; set; }
	}
}

