namespace BorderControl
{
	public class Identifiable
	{
		protected Identifiable(string id)
		{
			this.Id = id;
		}
		public string Id { get; set; }

		public override string ToString()
		{
			return $"{this.Id}";
		}
	}
}
