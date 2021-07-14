using System;
using System.Collections.Generic;

namespace CustomRandomList
{
	public class StartUp
	{
		public static void Main(string[] args)
		{

		}
	}

	public class RandomList : List<string>
	{
		public string RandomString()
		{
			Random randomElement = new Random();

			string elementToBeDeleted = this[randomElement.Next(0, this.Count)];
			this.Remove(elementToBeDeleted);
			return elementToBeDeleted;
		}
	}
}
