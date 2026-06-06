using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public static class Int64Comparisons
	{
		#region Fields
		private static readonly Comparison<long> descending = DescendingComparison;
		private static readonly Comparison<long> ascending = AscendingComparison;
		#endregion Fields

		#region Properties
		public static Comparison<long> Descending => descending;
		public static Comparison<long> Ascending => ascending;
		#endregion Properties

		#region Methods
		public static int DescendingComparison(long x, long y)
		{
			if (x == y)
			{
				return 0;
			}
			if (x < y)
			{
				return +1;
			}
			else
			{
				return -1;
			}
		}

		public static int AscendingComparison(long x, long y)
		{
			if (x == y)
			{
				return 0;
			}
			if (x > y)
			{
				return +1;
			}
			else
			{
				return -1;
			}
		}
		#endregion Methods
	}
}
