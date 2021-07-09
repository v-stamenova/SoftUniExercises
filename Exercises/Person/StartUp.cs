using System;
using System.Text;

namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Child child = new Child(name, age);
            Console.WriteLine(child);
        }
    }

    public class Person
	{
		private string name;
		private int age;

		public Person(string name, int age)
		{
			this.Name = name;
			this.Age = age;
		}

		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("The name cannot be empty");
				}
				else
				{
					this.name = value;
				}
			}
		}

		public int Age
		{
			get
			{
				return this.age;
			}
			set
			{
				if(value < 0)
				{
					throw new ArgumentException("The age cannot be less than zero");
				}
				else
				{
					this.age = value;
				}
			}
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(String.Format("Name: {0}, Age: {1}", this.Name, this.Age));

			return stringBuilder.ToString();
		}
	}

	public class Child : Person
	{
		public Child(string name, int age) : base(name, age)
		{
		}
	}
}