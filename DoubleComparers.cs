using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public static class DoubleComparers
	{
		#region Fields
		private static readonly DoubleDescendingComparer descending = new DoubleDescendingComparer();
		private static readonly DoubleAscendingComparer ascending = new DoubleAscendingComparer();
		#endregion Fields

		#region Properties
		public static DoubleDescendingComparer Descending => descending;
		public static DoubleAscendingComparer Ascending => ascending;
		#endregion Properties
	}
}
