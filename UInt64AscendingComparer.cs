using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public sealed class UInt64AscendingComparer : IComparer<ulong>
	{
		#region Methods
		public int Compare(ulong x, ulong y)
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
		#endregion //Methods
	}
}
