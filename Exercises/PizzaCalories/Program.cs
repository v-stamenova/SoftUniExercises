using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				List<string> data = Console.ReadLine().Split(' ').ToList();
				Pizza pizza = new Pizza(data[1]);

				data = Console.ReadLine().Split(' ').ToList();
				pizza.Dough = new Dough(data[1], data[2], double.Parse(data[3]));

				string input = Console.ReadLine();
				while (input != "END")
				{
					data = input.Split(' ').ToList();
					pizza.AddTopping(new Topping(data[1], double.Parse(data[2])));
					input = Console.ReadLine();
				}

				Console.WriteLine(pizza.ToString());
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
