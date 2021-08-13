using BorderControl;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Identifiable> identifiables = new List<Identifiable>();

			string input = Console.ReadLine();
			while (input != "End")
			{
				List<string> data = input.Split(' ').ToList();
				switch (data[0])
				{
					case "Citizen":
						identifiables.Add(new Person(data[1], int.Parse(data[2]), data[3], data[4]));
						break;
					case "Pet":
						identifiables.Add(new Pet(data[1], data[2]));
						break;
					case "Robot":
						identifiables.Add(new Robot(data[1], data[2]));
						break;
				}
				input = Console.ReadLine();
			}

			string year = Console.ReadLine();

			foreach(Identifiable identifiable in identifiables)
			{
				if(identifiable is IBirthdate)
				{
					if((identifiable as IBirthdate).Birthdate.Substring((identifiable as IBirthdate).Birthdate.Length - 4) == year)
					{
						Console.WriteLine((identifiable as IBirthdate).Birthdate);
					}
				}
			}
		}
	}
}
