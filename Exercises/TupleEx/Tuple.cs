namespace TupleEx
{
	class Tuple<Type1, Type2>
	{
		private Type1 item1;
		private Type2 item2;

		public Tuple(Type1 item1, Type2 item2)
		{
			this.item1 = item1;
			this.item2 = item2;
		}

		public override string ToString()
		{
			return $"{item1} -> {item2}";
		}
	}
}
