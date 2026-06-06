using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public static class DoubleComparisons
	{
		#region Fields
		private static readonly Comparison<double> descending = DescendingComparison;
		private static readonly Comparison<double> ascending = AscendingComparison;
		#endregion Fields

		#region Properties
		public static Comparison<double> Descending => descending;
		public static Comparison<double> Ascending => ascending;
		#endregion Properties

		#region Methods
		public static int DescendingComparison(double x, double y)
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

		public static int AscendingComparison(double x, double y)
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
