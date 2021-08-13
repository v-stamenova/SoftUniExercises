namespace BirthdayCelebrations
{
	class Person : BorderControl.Person, IBirthdate
	{
		public Person(string name, int age, string id, string birthdate) : base(name, age, id)
		{
			this.Birthdate = birthdate;			
		}

		public string Birthdate { get; set; }
	}
}
