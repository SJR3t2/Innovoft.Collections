using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public sealed class SingleAscendingComparer : IComparer<float>
	{
		#region Methods
		public int Compare(float x, float y)
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
