using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public static class DateTimeAscendingComparison
	{
		#region Methods
		public static int Comparison(DateTime x, DateTime y)
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
