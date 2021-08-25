using System;
using WildFarm.Foods;

namespace WildFarm.Animals.Mammals
{
	class Mouse : Mammal
	{
		public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
		{
		}

		public override string AskForFood()
		{
			return "Squeak";
		}

		public override void Feed(Food food)
		{
			if (food is Vegetable || food is Fruit)
			{
				this.Weight += food.Quantity * 0.10;
				this.FoodEaten += food.Quantity;
			}
			else
			{
				throw new Exception($"Mouse does not eat {food.GetType().Name}!");
			}
		}
	}
}
