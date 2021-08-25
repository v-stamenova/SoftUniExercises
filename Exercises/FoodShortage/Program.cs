using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Citizen> citizens = new List<Citizen>();
			List<Rebel> rebels = new List<Rebel>();

			int numberOfPeople = int.Parse(Console.ReadLine());
			for (int i = 0; i < numberOfPeople; i++)
			{
				List<string> data = Console.ReadLine().Split(' ').ToList();

				if (data.Count == 3)
				{
					rebels.Add(new Rebel(data[0], int.Parse(data[1]), data[2]));
				}
				else
				{
					citizens.Add(new Citizen(data[0], int.Parse(data[1]), data[2], data[3]));
				}
			}

			string buyerName = Console.ReadLine();
			while (buyerName != "End")
			{
				if(citizens.Any(x => x.Name == buyerName))
				{
					Citizen buyer = citizens.First(x => x.Name == buyerName);
					buyer.BuyFood();
				}
				else if (rebels.Any(x => x.Name == buyerName))
				{
					Rebel buyer = rebels.First(x => x.Name == buyerName);
					buyer.BuyFood();
				}
				buyerName = Console.ReadLine();
			}

			int foodBought = citizens.Sum(x => x.Food) + rebels.Sum(x => x.Food);

			Console.WriteLine(foodBought);
		}
	}
}
