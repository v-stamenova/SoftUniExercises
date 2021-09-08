using System;
using System.Collections.Generic;

namespace GenericCount
{
	class Program
	{
		static void Main(string[] args)
		{
			int inputLines = int.Parse(Console.ReadLine());
			List<Box<double>> list = new List<Box<double>>();

			for (int i = 0; i < inputLines; i++)
			{
				list.Add(new Box<double>(double.Parse(Console.ReadLine())));
			}

			Box<double> box = new Box<double>(double.Parse(Console.ReadLine()));

			Console.WriteLine(box.NumberOfElementsGreaterThan(list));
		}
	}
}
