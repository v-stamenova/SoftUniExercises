using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
	class Program
	{
		static void Main(string[] args)
		{
			int rangeEnd = int.Parse(Console.ReadLine());
			List<int> numbers = new List<int>();

			for(int i = 1; i <= rangeEnd; i++)
			{
				numbers.Add(i);
			}

			List<int> dividers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

			Func<int, bool> IsDivisible = number => Divisible(number, dividers);

			numbers = numbers.Where(x => IsDivisible(x)).ToList();

			Console.WriteLine(string.Join(' ', numbers));
		}

		static bool Divisible(int number, List<int> dividers)
		{
			foreach(int divider in dividers)
			{
				if(number % divider != 0)
				{
					return false;
				}
			}

			return true;
		}
	}
}
