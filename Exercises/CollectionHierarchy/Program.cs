using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionHierarchy
{
	public class Program
	{
		public static void Main(string[] args)
		{
			AddCollection addCollection = new AddCollection();
			AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
			MyList myList = new MyList();

			List<string> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
			string fCol = "";
			string sCol = "";
			string tCol = "";

			foreach(string st in input)
			{
				fCol += addCollection.Add(st);
				sCol += addRemoveCollection.Add(st);
				tCol += myList.Add(st);
			}

			int removeCount = int.Parse(Console.ReadLine());
			string rFCol = "";
			string rSCol = "";

			for(int i = 0; i < removeCount; i++)
			{
				rFCol += addRemoveCollection.Remove();
			}
			
			for(int i = 0; i < removeCount; i++)
			{
				rSCol += myList.Remove();
			}

			Console.WriteLine(fCol);
			Console.WriteLine(sCol);
			Console.WriteLine(tCol);
			Console.WriteLine(rFCol);
			Console.WriteLine(rSCol);
		}
	}
}
