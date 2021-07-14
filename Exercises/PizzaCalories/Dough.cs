using System;
using System.Collections.Generic;

namespace PizzaCalories
{
	public class Dough
	{
		private string flour;
		private string technique;
		private double weight;
		private Dictionary<string, double> mappingFlour = new Dictionary<string, double>()
		{
			{"white", 1.5 },
			{"wholegrain", 1.0 },
		};
		private Dictionary<string, double> mappingTechnique = new Dictionary<string, double>
		{
			{"crispy", 0.9 },
			{"chewy", 1.1 },
			{"homemade", 1.0 }
		};

		public Dough(string flour, string technique, double weight)
		{
			this.Flour = flour;
			this.Technique = technique;
			this.Weight = weight;
		}

		public string Flour
		{
			get
			{
				return this.flour;
			}
			private set
			{
				if (!mappingFlour.ContainsKey(value.ToLower()))
				{
					throw new Exception("Invalid type of dough.");
				}
				else
				{
					this.flour = value;
				}
			}
		}

		public string Technique
		{
			get
			{
				return this.technique;
			}
			private set
			{
				if (!mappingTechnique.ContainsKey(value.ToLower()))
				{
					throw new Exception("Invalid type of dough.");
				}
				else
				{
					this.technique = value;
				}
			}
		}

		public double Weight
		{
			get
			{
				return this.weight;
			}
			private set
			{
				if(value <= 0 || value > 200)
				{
					throw new Exception("Dough weight should be in the range [1..200].");
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
				return 2 * this.weight * this.mappingFlour[this.flour.ToLower()] * this.mappingTechnique[this.technique.ToLower()];
			}
		}
	}
}
