using System;
using System.Collections.Generic;

namespace CustomStack
{
	class StartUp
	{
		static void Main(string[] args)
		{
			Console.Write("Hello");
			Console.Write("World!");
		}
	}

	public class StackOfStrings : Stack<string>
	{
		public bool IsEmpty()
		{
			if(this.Count == 0)
			{
				return true;
			}

			return false;
		}

		public void AddRange(Stack<string> stack)
		{
			foreach(string st in stack)
			{
				this.Push(st);
			}
		}
	}
}
