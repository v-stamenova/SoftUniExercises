using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateForNames
{
	class Program
	{
		static void Main(string[] args)
		{
			int charLength = int.Parse(Console.ReadLine());
			List<string> names = Console.ReadLine().Split(' ').ToList();

			names = names.Where(x => x.Length <= charLength).ToList();
			names.ForEach(Console.WriteLine);
		}
	}
}
