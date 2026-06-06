using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public static class Int64DescendingComparison
	{
		#region Methods
		public static int Comparison(long x, long y)
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
