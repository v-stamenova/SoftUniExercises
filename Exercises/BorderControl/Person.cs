namespace BorderControl
{
	class Person : Identifiable
	{
		public Person(string name, int age, string id) : base(id)
		{
			this.Age = age;
			this.Name = name;
		}

		public int Age { get; set; }
		public string Name { get; set; }
	}
}
