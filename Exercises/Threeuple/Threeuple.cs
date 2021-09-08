namespace Threeuple
{
	class Threeuple<Type1, Type2, Type3>
	{
		private Type1 item1;
		private Type2 item2;
		private Type3 item3;

		public Threeuple(Type1 item1, Type2 item2, Type3 item3)
		{
			this.item1 = item1;
			this.item2 = item2;
			this.item3 = item3;
		}

		public override string ToString()
		{
			return $"{this.item1} -> {this.item2} -> {this.item3}";
		}
	}
}
