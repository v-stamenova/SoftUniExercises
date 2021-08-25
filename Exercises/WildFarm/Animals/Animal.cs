using WildFarm.Foods;

namespace WildFarm.Animals
{
	abstract class Animal
	{
		public Animal(string name, double weight)
		{
			this.Name = name;
			this.Weight = weight;
			this.FoodEaten = 0;
		}

		public string Name { get; set; }
		public double Weight { get; set; }
		public int FoodEaten { get; set; }

		public abstract string AskForFood();

		public abstract void Feed(Food food);
	}
}
