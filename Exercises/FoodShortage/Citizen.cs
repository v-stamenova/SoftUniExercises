namespace FoodShortage
{
	class Citizen : BirthdayCelebrations.Person, IBuyer
	{
		public Citizen(string name, int age, string id, string birthdate) : base(name, age, id, birthdate)
		{
			this.Food = 0;
		}

		public int Food { get; set; }

		public void BuyFood()
		{
			this.Food += 10;
		}
	}
}
