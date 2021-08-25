using System;
using WildFarm.Foods;

namespace WildFarm.Animals.Birds
{
	class Owl : Bird
	{
		public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
		{
		}

		public override string AskForFood()
		{
			return "Hoot Hoot";
		}

		public override void Feed(Food food)
		{
			if (food is Meat)
			{
				this.Weight += food.Quantity * 0.25;
				this.FoodEaten += food.Quantity;
			}
			else
			{
				throw new Exception($"Owl does not eat {food.GetType().Name}!");
			}
		}
	}
}
