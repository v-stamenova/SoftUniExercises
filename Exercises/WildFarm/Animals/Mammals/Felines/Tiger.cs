using System;
using WildFarm.Foods;

namespace WildFarm.Animals.Mammals.Felines
{
	class Tiger : Feline
	{
		public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
		{
		}

		public override string AskForFood()
		{
			return "ROAR!!!";
		}

		public override void Feed(Food food)
		{
			if (food is Meat)
			{
				this.Weight += food.Quantity * 1;
				this.FoodEaten += food.Quantity;
			}
			else
			{
				throw new Exception($"Tiger does not eat {food.GetType().Name}!");
			}
		}
	}
}
