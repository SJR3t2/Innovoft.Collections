using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public static class UInt64DescendingComparison
	{
		#region Methods
		public static int Comparison(ulong x, ulong y)
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
		#endregion //Methods
	}
}
