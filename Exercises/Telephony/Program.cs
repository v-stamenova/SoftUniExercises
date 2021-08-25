using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephony
{
	class Program
	{
		static void Main(string[] args)
		{
			Smartphone smartphone = new Smartphone();
			StationaryPhone stationaryPhone = new StationaryPhone();
			List<string> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
			List<string> urls = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

			foreach(string number in numbers)
			{
				if(number.Length == 7)
				{
					Console.WriteLine(stationaryPhone.Calling(number));
				}
				else
				{
					Console.WriteLine(smartphone.Calling(number));
				}
			}

			foreach(string url in urls)
			{
				Console.WriteLine(smartphone.Browsing(url));
			}
		}
	}
}
