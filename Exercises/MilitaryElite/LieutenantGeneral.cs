using System;
using System.Collections.Generic;

namespace MilitaryElite
{
	public class LieutenantGeneral : Private, Interfaces.ILieutenantGeneral
	{
		public LieutenantGeneral(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
		{
			this.Privates = new List<Private>();
		}

		public List<Private> Privates { get; set; }

		public override string ToString()
		{
			string output = $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary}";
			output += Environment.NewLine + "Privates:";
			foreach(Private pr in this.Privates)
			{
				output += Environment.NewLine + pr.ToString();
			}

			return output;
		}
	}
}
