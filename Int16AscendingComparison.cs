using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public static class Int16AscendingComparison
	{
		#region Methods
		public static int Comparison(short x, short y)
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
