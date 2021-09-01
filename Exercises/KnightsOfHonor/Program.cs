using System;
using System.Collections.Generic;
using System.Linq;

namespace KnightsOfHonor
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> input = Console.ReadLine().Split(' ').ToList();
			Action<string> print = Print;

			input.ForEach(x => print(x));
		}

		static void Print(string item)
		{
			Console.WriteLine($"Sir {item}");
		}
	}
}
