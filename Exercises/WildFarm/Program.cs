using System;
using System.Collections.Generic;
using System.Linq;
using WildFarm.Animals;
using WildFarm.Animals.Birds;
using WildFarm.Animals.Mammals;
using WildFarm.Animals.Mammals.Felines;
using WildFarm.Foods;

namespace WildFarm
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Animal> animals = new List<Animal>();
			string input = Console.ReadLine();

			while(input != "End")
			{
				Animal animal;
				List<string> data = input.Split(' ').ToList();
				switch (data[0])
				{
					case "Cat":
						animal = new Cat(data[1], double.Parse(data[2]), data[3], data[4]);
						break;
					case "Tiger":
						animal = new Tiger(data[1], double.Parse(data[2]), data[3], data[4]);
						break;
					case "Owl":
						animal = new Owl(data[1], double.Parse(data[2]), double.Parse(data[3]));
						break;
					case "Hen":
						animal = new Owl(data[1], double.Parse(data[2]), double.Parse(data[3]));
						break;
					case "Dog":
						animal = new Dog(data[1], double.Parse(data[2]), data[3]);
						break;
					default:
						animal = new Mouse(data[1], double.Parse(data[2]), data[3]);
						break;
				}

				input = Console.ReadLine();
				data = input.Split(' ').ToList();

				Console.WriteLine(animal.AskForFood());

				Food food;
				switch (data[0])
				{
					case "Vegetable":
						food = new Vegetable(int.Parse(data[1]));
						break;
					case "Meat":
						food = new Meat(int.Parse(data[1]));
						break;
					case "Fruit":
						food = new Fruit(int.Parse(data[1]));
						break;
					default:
						food = new Seeds(int.Parse(data[1]));
						break;
				}
				try
				{
					animal.Feed(food);
				}
				catch(Exception e)
				{
					Console.WriteLine(e.Message);
				}
				animals.Add(animal);

				input = Console.ReadLine();
			}

			animals.ForEach(Console.WriteLine);
		}
	}
}
