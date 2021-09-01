using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> names = Console.ReadLine().Split(' ').ToList();

			string input = Console.ReadLine();
			while(input != "Party!")
			{
				List<string> data = input.Split(' ').ToList();

				List<string> alt = new List<string>();
				switch (data[1])
				{
					case "StartsWith":
						alt = names.Where(x => x.StartsWith(data[2])).ToList();
						break;
					case "EndsWith":
						alt = names.Where(x => x.EndsWith(data[2])).ToList();
						break;
					case "Length":
						alt = names.Where(x => x.Length == int.Parse(data[2])).ToList();
						break;
				}

				if(data[0] == "Double")
				{
					names.AddRange(alt);
				}
				else
				{
					names.RemoveAll(x => alt.Contains(x));
				}

				input = Console.ReadLine();
			}

			if(names.Count == 0)
			{
				Console.WriteLine("Nobody is going to the party!");
			}
			else
			{
				Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
			}
		}
	}
}
