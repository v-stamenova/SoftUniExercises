using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Person> people = new List<Person>();
			List<Product> products = new List<Product>();
			List<string> data = Console.ReadLine().Split(new Char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries).ToList();

			while(data.Count != 0)
			{
				try
				{
					Person person = new Person(data[0], decimal.Parse(data[1]));
					data.RemoveRange(0, 2);
					people.Add(person);
				}
				catch(Exception e)
				{
					Console.WriteLine(e.Message);
					Environment.Exit(0);
				}
			}

			data = Console.ReadLine().Split(new Char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries).ToList();

			while(data.Count != 0)
			{
				try
				{
					Product product = new Product(data[0], decimal.Parse(data[1]));
					data.RemoveRange(0, 2);
					products.Add(product);
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					Environment.Exit(0);
				}
			}

			string input = Console.ReadLine();
			while (input != "END")
			{
				data = input.Split(' ').ToList();
				Console.WriteLine(people.Find(x => x.Name == data[0]).BuyProduct(products.Find(y => y.Name == data[1])));
				input = Console.ReadLine();
			}

			Console.WriteLine(string.Join(Environment.NewLine, people));
		}
	}
}
