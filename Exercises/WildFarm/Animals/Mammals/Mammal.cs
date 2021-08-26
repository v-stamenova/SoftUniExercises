using WildFarm.Foods;

namespace WildFarm.Animals.Mammals
{
	class Mammal : Animal
	{
		public Mammal(string name, double weight, string livingRegion) : base(name, weight)
		{
			this.LivingRegion = livingRegion;
		}

		public string LivingRegion { get; set; }

		public override string AskForFood()
		{
			throw new System.NotImplementedException();
		}

		public override void Feed(Food food)
		{
			throw new System.NotImplementedException();
		}

		public override string ToString()
		{
			return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
		}
	}
}
