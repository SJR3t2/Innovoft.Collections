using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public static class UInt32DescendingComparison
	{
		#region Methods
		public static int Comparison(uint x, uint y)
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
