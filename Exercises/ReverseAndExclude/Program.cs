using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			int divider = int.Parse(Console.ReadLine());

			input = input.Where(x => x % divider != 0).ToList();
			input.Reverse();

			Console.WriteLine(string.Join(' ', input));
		}
	}
}
