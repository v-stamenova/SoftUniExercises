﻿namespace WildFarm.Foods
{
	abstract class Food
	{
		public Food(int quantity)
		{
			this.Quantity = quantity;
		}

		public int Quantity { get; set; }
	}
}
