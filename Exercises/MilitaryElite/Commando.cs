using System;
using System.Collections.Generic;

namespace MilitaryElite
{
	class Commando : Private, Interfaces.ICommando
	{
		public Commando(int id, string firstName, string lastName, decimal salary, Corps corps) : base(id, firstName, lastName, salary)
		{
			this.Corps = corps;
			this.Missions = new List<Mission>();
		}

		public Corps Corps { get; set; }
		public List<Mission> Missions { get; set; }

		public override string ToString()
		{
			string output = $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary}{Environment.NewLine}";
			output += $"Corps: {this.Corps}{Environment.NewLine}";
			output += $"Missions:";

			foreach (Mission m in this.Missions)
			{
				output += Environment.NewLine + m.ToString();
			}

			return output;
		}
	}
}
