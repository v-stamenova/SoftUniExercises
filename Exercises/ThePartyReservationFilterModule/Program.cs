using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePartyReservationFilterModule
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> names = Console.ReadLine().Split(' ').ToList();
			Dictionary<string, Predicate<string>> predicates = new Dictionary<string, Predicate<string>>();

			string input = Console.ReadLine();
			while(input != "Print")
			{
				List<string> data = input.Split(';').ToList();
				Predicate<string> predicate;

				switch (data[1])
				{
					case "Starts with":
						predicate = x => x.StartsWith(data[2]);
						break;
					case "Ends with":
						predicate = x => x.EndsWith(data[2]);
						break;
					case "Length":
						predicate = x => x.Length == int.Parse(data[2]);
						break;
					default:
						predicate = x => x.Contains(data[2]);
						break;
				}

				if(data[0] == "Add filter")
				{
					predicates.Add($"{data[1]} {data[2]}", predicate);
				}
				else
				{
					predicates.Remove($"{data[1]} {data[2]}");
				}
				input = Console.ReadLine();
			}

			foreach (KeyValuePair<string, Predicate<string>> keyValue in predicates)
			{
				names.RemoveAll(x => keyValue.Value(x));
			}

			Console.WriteLine(string.Join(" ", names));
		}
	}
}
