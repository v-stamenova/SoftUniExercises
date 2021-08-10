using System.Collections.Generic;

namespace CollectionHierarchy
{
	public class AddCollection : IStringCollection
	{
		private List<string> collection = new List<string>();

		public int Add(string item)
		{
			this.collection.Add(item);
			return this.collection.Count - 1;
		}
	}
}
