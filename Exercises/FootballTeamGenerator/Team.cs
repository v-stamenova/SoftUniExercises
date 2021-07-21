using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
	public class Team
	{
		private string name;
		private List<Player> players;

		public Team(string name)
		{
			this.Name = name;
			players = new List<Player>();
		}

		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new Exception("A name should not be empty.");
				}
				else
				{
					this.name = value;
				}
			}
		}

		public double Rating
		{
			get
			{
				if (this.players.Count == 0)
				{
					return 0;
				}
				else
				{
					return Math.Round((this.players.Sum(x => x.SkillLevel) / this.players.Count));
				}
			}
		}

		public List<Player> Players
		{
			get
			{
				return this.players;
			}
			set
			{
				this.players = value;
			}
		}

		public void RemovePlayer(string name)
		{
			if(this.players.Any(x => x.Name == name))
			{
				this.players.Remove(this.players.Find(x => x.Name == name));
			}
			else
			{
				throw new Exception($"Player {name} is not in {this.name} team.");
			}
		}
	}
}
