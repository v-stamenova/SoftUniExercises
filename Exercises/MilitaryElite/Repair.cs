﻿namespace MilitaryElite
{
	public class Repair : Interfaces.IRepair
	{
		public Repair(string partName, int workedHours)
		{
			this.PartName = partName;
			this.WorkedHours = workedHours;
		}

		public string PartName { get; set; }
		public int WorkedHours { get; set; }

		public override string ToString()
		{
			return $"Part Name: {this.PartName} Hours Worked: {this.WorkedHours}";
		}
	}
}
