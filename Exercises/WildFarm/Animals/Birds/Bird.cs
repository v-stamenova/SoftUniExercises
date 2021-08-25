using WildFarm.Foods;

namespace WildFarm.Animals.Birds
{
	class Bird : Animal
	{
		public Bird(string name, double weight, double wingSize) : base(name, weight)
		{
			this.WingSize = wingSize;
		}

		public double WingSize { get; set; }

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
			return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
		}
	}
}
