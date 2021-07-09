using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
			List<Animal> animals = new List<Animal>();

			string input = Console.ReadLine();
			List<string> data = new List<string>();

			while (input != "Beast!")
			{
				data = Console.ReadLine().Split(' ').ToList();
				Animal animal;
				switch (input)
				{
					case "Dog":
						animal = new Dog(data[0], int.Parse(data[1]), data[2]);
						break;
					case "Cat":
						animal = new Cat(data[0], int.Parse(data[1]), data[2]);
						break;
					case "Frog":
						animal = new Frog(data[0], int.Parse(data[1]), data[2]);
						break;
					case "Kitten":
						animal = new Kitten(data[0], int.Parse(data[1]));
						break;
					case "Tomcat":
						animal = new Tomcat(data[0], int.Parse(data[1]));
						break;
					default:
						throw new Exception();
				}
				animals.Add(animal);

				input = Console.ReadLine();
			}

			foreach(Animal a in animals)
			{
				Console.WriteLine(a.ToString());;
			}
        }
    }

    public class Animal
	{
        private string name;
        private int age;
        private string gender;

		public Animal()
		{
		}

		public Animal(string name, int age, string gender)
		{
			this.Name = name;
			this.Age = age;
			this.Gender = gender;
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
					throw new Exception("Invalid input!");
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
				if (value <= 0)
				{
					throw new Exception("Invalid input!");
				}
				else
				{
					this.age = value;
				}
			}
		}

		public string Gender
		{
			get
			{
				return this.gender;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new Exception("Invalid input!");
				}
				else
				{
					this.gender = value;
				}
			}
		}

		public virtual string ProduceSound()
		{
			throw new Exception();
		}

		public override string ToString()
		{
			return $"{this.GetType().Name}{Environment.NewLine}{this.Name} {this.Age} {this.Gender}{Environment.NewLine}{this.ProduceSound()}";
		}
	}

	public class Cat : Animal
	{
		public Cat(string name, int age, string gender) : base(name, age, gender)
		{
		}

		public override string ProduceSound()
		{
			return "Meow meow";
		}
	}

	public class Kitten : Cat
	{
		public Kitten(string name, int age) : base(name, age, "Female")
		{
		}

		public override string ProduceSound()
		{
			return "Meow";
		}
	}

	public class Tomcat : Cat
	{
		public Tomcat(string name, int age) : base(name, age, "Male")
		{
		}

		public override string ProduceSound()
		{
			return "MEOW";
		}
	}

	public class Dog : Animal
	{
		public Dog(string name, int age, string gender) : base(name, age, gender)
		{
		}

		public override string ProduceSound()
		{
			return "Woof!";
		}
	}

	public class Frog : Animal
	{
		public Frog(string name, int age, string gender) : base(name, age, gender)
		{
		}

		public override string ProduceSound()
		{
			return "Ribbit";
		}
	}
}
