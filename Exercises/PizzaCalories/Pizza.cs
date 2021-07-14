using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
	public class Pizza
	{
		private string name;
		private Dough dough;
		private List<Topping> toppings;

		public Pizza(string name)
		{
			this.Name = name;
			this.toppings = new List<Topping>();
		}

		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				if(string.IsNullOrWhiteSpace(value) || value.Length > 15)
				{
					throw new Exception("Pizza name should be between 1 and 15 symbols.");
				}
				else
				{
					this.name = value;
				}
			}
		}

		public Dough Dough
		{
			get
			{
				return this.dough;
			}
			set
			{
				this.dough = value;
			}
		}

		public List<Topping> Toppings
		{
			get
			{
				return this.toppings;
			}
		}

		public double Calories
		{
			get
			{
				return this.dough.Calories + this.toppings.Sum(x => x.Calories);
			}
		}

		public void AddTopping(Topping topping)
		{
			if(this.toppings.Count + 1 > 10)
			{
				throw new Exception("Number of toppings should be in range [0..10].");
			}
			else
			{
				this.toppings.Add(topping);
			}
		}

		public override string ToString()
		{
			return $"{this.name} - {string.Format("{0:#.00}", this.Calories)} Calories.";
		}
	}
}
