using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
	public class Person
	{
		private string name;
		private decimal money;
		private List<Product> bag;

		public Person(string name, decimal money)
		{
			this.Name = name;
			this.Money = money;
			this.bag = new List<Product>();
		}

		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new Exception("Name cannot be empty");
				}
				else
				{
					this.name = value;
				}
			}
		}

		public decimal Money
		{
			get
			{
				return this.money;
			}
			set
			{
				if (value < 0)
				{
					throw new Exception("Money cannot be negative");
				}
				else
				{
					this.money = value;
				}
			}
		}

		public List<Product> Bag
		{
			get
			{
				return this.bag;
			}
		}

		public string BuyProduct(Product product)
		{
			if (product is null)
			{
				return $"{this.name} - Nothing bought";
			}
			
			if(this.money - product.Cost < 0)
			{
				return $"{this.name} can't afford {product.Name}";
			}

			this.money -= product.Cost;
			this.bag.Add(product);
			return $"{this.name} bought {product.Name}";
		}

		public override string ToString()
		{
			if(this.bag.Count == 0)
			{
				return $"{this.name} - Nothing bought";
			}

			return $"{this.name} - {string.Join(", ", this.bag)}";
		}
	}
}
