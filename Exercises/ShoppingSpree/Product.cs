﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
	public class Product
	{
		private string name;
		private decimal cost;

		public Product(string name, decimal cost)
		{
			this.Name = name;
			this.Cost = cost;
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

		public decimal Cost
		{
			get
			{
				return this.cost;
			}
			set
			{
				if(value <= 0)
				{
					throw new Exception("Money cannot be negative");
				}
				else
				{
					this.cost = value;
				}
			}
		}

		public override string ToString()
		{
			return this.name;
		}
	}
}
