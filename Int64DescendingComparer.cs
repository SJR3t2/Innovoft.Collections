using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public sealed class Int64DescendingComparer : IComparer<long>
	{
		#region Methods
		public int Compare(long x, long y)
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
		#endregion Methods
	}
}
