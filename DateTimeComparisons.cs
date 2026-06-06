using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public static class DateTimeComparisons
	{
		#region Fields
		private static readonly Comparison<DateTime> descending = DescendingComparison;
		private static readonly Comparison<DateTime> ascending = AscendingComparison;
		#endregion Fields

		#region Properties
		public static Comparison<DateTime> Descending => descending;
		public static Comparison<DateTime> Ascending => ascending;
		#endregion Properties

		#region Methods
		public static int DescendingComparison(DateTime x, DateTime y)
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

		public static int AscendingComparison(DateTime x, DateTime y)
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
