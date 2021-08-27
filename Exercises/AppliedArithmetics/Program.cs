using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedArithmetics
{
	class Program
	{
		static List<int> numbers;

		static void Main(string[] args)
		{
			numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			string input = Console.ReadLine();

			while (input != "end")
			{
				switch (input)
				{
					case "add":
						Add();
						break;
					case "multiply":
						Multiply();
						break;
					case "subtract":
						Subtract();
						break;
					case "print":
						Print();
						break;
				}
				if(input == "end")
				{
					break;
				}
				input = Console.ReadLine();
			}
		}

		static void Add()
		{
			numbers = numbers.Select(x => { x++ ; return x; }).ToList();
		}

		static void Multiply()
		{
			numbers = numbers.Select(x => { x = x * 2; return x; }).ToList();
		}

		static void Subtract()
		{
			numbers = numbers.Select(x => { x--; return x; }).ToList();
		}

		static void Print()
		{
			Console.WriteLine(String.Join(' ', numbers));
		}
	}
}
