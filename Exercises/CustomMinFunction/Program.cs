using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomMinFunction
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			Console.WriteLine(MinNumber(numbers));
		}

		static Func<List<int>, int> MinNumber = (List<int> numbers) => numbers.Min();
	}
}
