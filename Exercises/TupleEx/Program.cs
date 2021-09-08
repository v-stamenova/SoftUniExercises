using System;
using System.Collections.Generic;
using System.Linq;

namespace TupleEx
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> input = Console.ReadLine().Split(' ').ToList();
			Tuple<string, string> firstTuple = new Tuple<string, string>($"{input[0]} {input[1]}", input[2]);

			input = Console.ReadLine().Split(' ').ToList();
			Tuple<string, int> secondTuple = new Tuple<string, int>(input[0], int.Parse(input[1]));

			input = Console.ReadLine().Split(' ').ToList();
			Tuple<string, double> thirdTuple = new Tuple<string, double>(input[0], double.Parse(input[1]));
		}
	}
}
