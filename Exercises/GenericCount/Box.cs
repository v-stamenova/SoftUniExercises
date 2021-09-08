using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace GenericCount
{
	class Box<T> : IComparable<T> where T : IComparable
	{
		private T value;

		public Box(T value)
		{
			this.value = value;
		}

		public T Value { get; set; }

		public int CompareTo([AllowNull] T other)
		{
			return value.CompareTo(other);
		}

		public override string ToString()
		{
			return $"{value.GetType().FullName}: {value}";
		}

		public int NumberOfElementsGreaterThan(List<Box<T>> list)
		{
			return list.Count(x => x.CompareTo(this.value) > 0);
		}
	}
}
