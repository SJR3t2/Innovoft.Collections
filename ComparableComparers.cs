using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public static class ComparableComparers<T>
		where T: IComparable<T>
	{
		#region Fields
		private static readonly ComparableAscendingComparer<T> ascending = new ComparableAscendingComparer<T>();
		private static readonly ComparableDescendingComparer<T> descending = new ComparableDescendingComparer<T>();
		#endregion Fields

		#region Properties
		public static ComparableAscendingComparer<T> Ascending => ascending;
		public static ComparableDescendingComparer<T> Descending => descending;
		#endregion Properties
	}
}
