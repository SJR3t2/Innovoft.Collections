using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public sealed class UInt16DescendingComparer : IComparer<ushort>
	{
		#region Methods
		public int Compare(ushort x, ushort y)
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
