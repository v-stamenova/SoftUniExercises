using System;

namespace GenericBox
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfLines = int.Parse(Console.ReadLine());

			for (int i = 0; i < numberOfLines; i++)
			{
				Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));
				Console.WriteLine(box.ToString());
			}
		}
	}
}
