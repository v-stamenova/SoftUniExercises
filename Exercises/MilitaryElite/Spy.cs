﻿using System;

namespace MilitaryElite
{
	class Spy : Soldier, Interfaces.ISpy
	{
		public Spy(int id, string firstName, string lastName, int codeNumber) : base(id, firstName, lastName)
		{
			this.CodeNumber = codeNumber;
		}

		public int CodeNumber { get; set; }

		public override string ToString()
		{
			return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}{Environment.NewLine}Code Number: {this.CodeNumber}";
		}
	}
}
