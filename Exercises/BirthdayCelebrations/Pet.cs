namespace BirthdayCelebrations
{
	class Pet : BorderControl.Identifiable, IBirthdate
	{
		public Pet(string name, string birthdate) : base(null)
		{
			this.Name = name;
			this.Birthdate = birthdate;
		}

		public string Name { get; set; }
		public string Birthdate { get; set; }
	}
}
