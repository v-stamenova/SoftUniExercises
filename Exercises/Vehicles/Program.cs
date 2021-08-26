using System;
using System.Collections.Generic;
using System.Linq;
using Vehicles.Vehicles;

namespace Vehicles
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Vehicle> vehicles = new List<Vehicle>();
			for (int i = 0; i < 3; i++)
			{
				List<string> data = Console.ReadLine().Split(' ').ToList();
				switch (data[0])
				{
					case "Car":
						vehicles.Add(new Car(double.Parse(data[1]), double.Parse(data[2]), double.Parse(data[3])));
						break;
					case "Bus":
						vehicles.Add(new Bus(double.Parse(data[1]), double.Parse(data[2]), double.Parse(data[3])));
						break;
					case "Truck":
						vehicles.Add(new Truck(double.Parse(data[1]), double.Parse(data[2]), double.Parse(data[3])));
						break;
				}
			}

			int numberOfCommands = int.Parse(Console.ReadLine());
			Bus bus = (Bus)vehicles.Find(x => x is Bus);
			Car car = (Car)vehicles.Find(x => x is Car);
			Truck truck = (Truck)vehicles.Find(x => x is Truck);

			for (int i = 0; i < numberOfCommands; i++)
			{
				try
				{
					List<string> data = Console.ReadLine().Split(' ').ToList();

					if (data[0] == "Refuel")
					{
						if (data[1] == "Car")
						{
							car.Refuel(double.Parse(data[2]));
						}
						else if (data[1] == "Truck")
						{
							truck.Refuel(double.Parse(data[2]));
						}
						else
						{
							bus.Refuel(double.Parse(data[2]));
						}
					}
					else if (data[0] == "Drive")
					{
						if (data[1] == "Car")
						{
							Console.WriteLine(car.Drive(double.Parse(data[2])));
						}
						else if (data[1] == "Truck")
						{
							Console.WriteLine(truck.Drive(double.Parse(data[2])));
						}
						else
						{
							bus.HasPeople = true;
							Console.WriteLine(bus.Drive(double.Parse(data[2])));
						}
					}
					else
					{
						bus.HasPeople = false;
						Console.WriteLine(bus.Drive(double.Parse(data[2])));
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}

			Console.WriteLine($"Car: {String.Format("{0:0.00}", car.FuelQuantity)}");
			Console.WriteLine($"Truck: {String.Format("{0:0.00}", truck.FuelQuantity)}");
			Console.WriteLine($"Bus: {String.Format("{0:0.00}", bus.FuelQuantity)}");
		}
	}
}
