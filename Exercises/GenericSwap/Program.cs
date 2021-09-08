using System;
using System.Collections.Generic;
using System.Linq;
using GenericBox;

namespace GenericSwap
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfLines = int.Parse(Console.ReadLine());
			List<Box<int>> boxes = new List<Box<int>>();

			for (int i = 0; i < numberOfLines; i++)
			{
				boxes.Add(new Box<int>(int.Parse(Console.ReadLine())));
			}

			List<int> indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			boxes = Swap(boxes, indexes[0], indexes[1]);

			boxes.ForEach(Console.WriteLine);
		}

		static List<T> Swap<T>(List<T> list, int firstIndex, int secondIndex)
		{
			T temp = list[firstIndex];
			list[firstIndex] = list[secondIndex];
			list[secondIndex] = temp;

			return list;
		}
	}
}
