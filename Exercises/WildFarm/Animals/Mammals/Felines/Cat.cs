using System;
using WildFarm.Foods;

namespace WildFarm.Animals.Mammals.Felines
{
	class Cat : Feline
	{
		public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
		{
		}

		public override string AskForFood()
		{
			return "Meow";
		}

		public override void Feed(Food food)
		{
			if (food is Meat || food is Vegetable)
			{
				this.Weight += food.Quantity * 0.30;
				this.FoodEaten += food.Quantity;
			}
			else
			{
				throw new Exception($"Cat does not eat {food.GetType().Name}!");
			}
		}
	}
}
