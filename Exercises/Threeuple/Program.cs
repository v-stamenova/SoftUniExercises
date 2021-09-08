using System;
using System.Collections.Generic;
using System.Linq;

namespace Threeuple
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> input = Console.ReadLine().Split(' ').ToList();
			Threeuple<string, string, string> first = new Threeuple<string, string, string>($"{input[0]} {input[1]}", input[2], input[3]);

			input = Console.ReadLine().Split(' ').ToList();
			bool b;
			if (input[2] == "drunk")
			{
				b = true;
			}
			else
			{
				b = false;
			}
			Threeuple<string, int, bool> second = new Threeuple<string, int, bool>(input[0], int.Parse(input[1]), b);

			input = Console.ReadLine().Split(' ').ToList();
			Threeuple<string, double, string> third = new Threeuple<string, double, string>(input[0], double.Parse(input[1]), input[2]);

			Console.WriteLine(first);
			Console.WriteLine(second);
			Console.WriteLine(third);
		}
	}
}
