using System;
using System.Collections.Generic;

namespace MilitaryElite
{
	public class Engineer : Private, Interfaces.IEngineer
	{
		public Engineer(int id, string firstName, string lastName, decimal salary, Corps corps) : base(id, firstName, lastName, salary)
		{
			this.Corps = corps;
			this.Repairs = new List<Repair>();
		}

		public Corps Corps { get; set; }
		public List<Repair> Repairs { get; set; }

		public override string ToString()
		{
			string output = $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary}{Environment.NewLine}";
			output += $"Corps: {this.Corps}{Environment.NewLine}";
			output += $"Repairs:";

			foreach (Repair r in this.Repairs)
			{
				output += Environment.NewLine + r.ToString();
			}

			return output;
		}
	}
}
