namespace MilitaryElite
{
	public abstract class SpecialSoldier : Private, Interfaces.ISpecialisedSoldier
	{
		public SpecialSoldier(int id, string firstName, string lastName, decimal salary, Corps corps) : base(id, firstName, lastName, salary)
		{
			this.Corps = corps;
		}

		public Corps Corps { get; set; }
	}
}
