using WildFarm.Foods;

namespace WildFarm.Animals.Birds
{
	class Hen : Bird
	{
		public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
		{
		}

		public override string AskForFood()
		{
			return "Cluck";
		}

		public override void Feed(Food food)
		{
			this.Weight += food.Quantity * 0.35;
			this.FoodEaten += food.Quantity;
		}
	}
}
