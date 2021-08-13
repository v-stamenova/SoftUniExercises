using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Identifiable> identifiables = new List<Identifiable>();

			string input = Console.ReadLine();
			while(input != "End")
			{
				List<string> data = input.Split(' ').ToList();
				if(data.Count == 2)
				{
					identifiables.Add(new Robot(data[0], data[1]));
				}
				else
				{
					identifiables.Add(new Person(data[0], int.Parse(data[1]), data[2]));
				}
				input = Console.ReadLine();
			}

			string fakeIdNumbers = Console.ReadLine();
			List<Identifiable> fakedId = identifiables.Where(x => x.Id.Substring(x.Id.Length - fakeIdNumbers.Length) == fakeIdNumbers).ToList();

			Console.WriteLine(string.Join(Environment.NewLine, fakedId));
		}
	}
}
