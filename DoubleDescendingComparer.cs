using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public sealed class DoubleDescendingComparer : IComparer<double>
	{
		#region Methods
		public int Compare(double x, double y)
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
