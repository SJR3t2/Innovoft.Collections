using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public static class Int64Comparers
	{
		#region Fields
		private static readonly Int64DescendingComparer descending = new Int64DescendingComparer();
		private static readonly Int64AscendingComparer ascending = new Int64AscendingComparer();
		#endregion Fields

		#region Properties
		public static Int64DescendingComparer Descending => descending;
		public static Int64AscendingComparer Ascending => ascending;
		#endregion Properties
	}
}
