using System;
using WildFarm.Foods;

namespace WildFarm.Animals.Mammals
{
	class Dog : Mammal
	{
		public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
		{
		}

		public override string AskForFood()
		{
			return "Woof!";		
		}
		public override void Feed(Food food)
		{
			if (food is Meat)
			{
				this.Weight += food.Quantity * 0.40;
				this.FoodEaten += food.Quantity;
			}
			else
			{
				throw new Exception($"Dog does not eat {food.GetType().Name}!");
			}
		}

	}
}
