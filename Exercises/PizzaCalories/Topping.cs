using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
	public class Topping
	{
		private string type;
		private double weight;
		private Dictionary<string, double> mappingType = new Dictionary<string, double>
		{
			{"meat", 1.2 },
			{"veggies", 0.8 },
			{"cheese", 1.1 },
			{"sauce", 0.9 }
		};

		public Topping(string type, double weight)
		{
			this.Type = type;
			this.Weight = weight;
		}

		public string Type
		{
			get
			{
				return this.type;
			}
			set
			{
				if (!mappingType.ContainsKey(value.ToLower()))
				{
					throw new Exception($"Cannot place {value} on top of your pizza.");
				}
				else
				{
					this.type = value;
				}
			}
		}

		public double Weight
		{
			get
			{
				return this.weight;
			}
			set
			{
				if(value < 0 || value > 50)
				{
					throw new Exception($"{this.type} weight should be in the range [1..50].");
				}
				else
				{
					this.weight = value;
				}
			}
		}
		public double Calories
		{
			get
			{
				return 2 * this.weight * mappingType[this.type.ToLower()];
			}
		}

	}
}
