﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
	public class Player
	{
		private string name;
		private int endurance;
		private int dribble;
		private int passing;
		private int shooting;
		private int sprint;

		public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
		{
			this.Name = name;
			this.Endurance = endurance;
			this.Dribble = dribble;
			this.Passing = passing;
			this.Shooting = shooting;
			this.Sprint = sprint;
		}

		public double SkillLevel
		{
			get
			{
				return Math.Round((double)(this.endurance + this.dribble + this.passing + this.shooting + this.sprint) / 5);
			}
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
					throw new ArgumentException("A name should not be empty.");
				}
				else
				{
					this.name = value;
				}
			}
		}

		public int Endurance
		{
			get
			{
				return this.endurance;
			}
			set
			{
				if(value < 0 || value > 100)
				{
					throw new ArgumentException("Endurance should be between 0 and 100.");
				}
				else
				{
					this.endurance = value;
				}
			}
		}

		public int Dribble
		{
			get
			{
				return this.dribble;
			}
			set
			{
				if (value < 0 || value > 100)
				{
					throw new ArgumentException("Dribble should be between 0 and 100.");
				}
				else
				{
					this.dribble = value;
				}
			}
		}

		public int Passing
		{
			get
			{
				return this.passing;
			}
			set
			{
				if (value < 0 || value > 100)
				{
					throw new ArgumentException("Passing should be between 0 and 100.");
				}
				else
				{
					this.passing = value;
				}
			}
		}

		public int Shooting
		{
			get
			{
				return this.shooting;
			}
			set
			{
				if (value < 0 || value > 100)
				{
					throw new ArgumentException("Shooting should be between 0 and 100.");
				}
				else
				{
					this.shooting = value;
				}
			}
		}

		public int Sprint
		{
			get
			{
				return this.sprint;
			}
			set
			{
				if (value < 0 || value > 100)
				{
					throw new ArgumentException("Sprint should be between 0 and 100.");
				}
				else
				{
					this.sprint = value;
				}
			}
		}
	}
}
