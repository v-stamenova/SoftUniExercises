﻿using System;

namespace Farm
{
	public class StartUp
	{
		public static void Main(string[] args)
		{
			Dog dog = new Dog();
			dog.Bark();
			dog.Bark();
		}
	}

	public class Animal
	{
		public void Eat()
		{
			Console.WriteLine("eating…");
		}
	}

	public class Dog : Animal
	{
		public void Bark()
		{
			Console.WriteLine("barking…");
		}
	}

	class Puppy : Dog
	{
		public void Weep()
		{
			Console.WriteLine("weeping…");
		}
	}

	public class Cat : Animal
	{
		public void Meow()
		{
			Console.WriteLine("meowing…");
		}
	}
}
