using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public static class ComparableComparisons<T>
		where T: IComparable<T>
	{
		#region Fields
		private static readonly Comparison<T> ascending = AscendingComparison;
		private static readonly Comparison<T> descending = DescendingComparison;
		#endregion Fields

		#region Properties
		public static Comparison<T> Ascending => ascending;
		public static Comparison<T> Descending => descending;
		#endregion Properties

		#region Methods
		public static int AscendingComparison(T x, T y)
		{
			return x.CompareTo(y);
		}

		public static int DescendingComparison(T x, T y)
		{
			return y.CompareTo(x);
		}
		#endregion Methods
	}
}
