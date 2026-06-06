using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public static class SByteAscendingComparison
	{
		#region Methods
		public static int Comparison(sbyte x, sbyte y)
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
