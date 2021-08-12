using System;
using System.Collections.Generic;
using System.Linq;

namespace ExplicitInterfaces
{
	class Program
	{
		static void Main(string[] args)
		{
			string line = Console.ReadLine();
			while (line != "End")
			{
				List<string> data = line.Split(' ').ToList();
				Citizen citizen = new Citizen(data[0], int.Parse(data[2]), data[1]);
				IPerson person = citizen;
				IResident resident = citizen;
				Console.WriteLine(person.GetName());
				Console.WriteLine(resident.GetName());
				line = Console.ReadLine();
			}
		}
	}
	}
}
