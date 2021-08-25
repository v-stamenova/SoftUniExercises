using System.Collections.Generic;
using System.Linq;

namespace CollectionHierarchy
{
	public class AddRemoveCollection : IStringCollection
	{
		private List<string> collection = new List<string>();

		public int Add(string item)
		{
			this.collection.Insert(0, item);
			return 0;
		}

		public string Remove()
		{
			string itemToBeRemoved = this.collection.Last();
			this.collection.Remove(itemToBeRemoved);
			return itemToBeRemoved;
		}
	}
}
