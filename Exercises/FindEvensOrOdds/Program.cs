using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
	class Program
	{
		static void Main(string[] args)
		{
			Predicate<int> isEven = IsEven;
			List<int> borders = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			List<int> numbers = new List<int>();

			for(int i = borders[0]; i <= borders[1]; i++)
			{
				numbers.Add(i);
			}

			string oddOrEven = Console.ReadLine();
			List<int> selectedNumbers;
			if(oddOrEven == "odd")
			{
				selectedNumbers = numbers.Where(x => !isEven(x)).ToList();
			}
			else
			{
				selectedNumbers = numbers.Where(x => isEven(x)).ToList();
			}

			Console.WriteLine(string.Join(' ', selectedNumbers));
		}

		static bool IsEven(int number)
		{
			if(number % 2 == 0)
			{
				return true;
			}
			return false;
		}
	}
}
