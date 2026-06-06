using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public sealed class ComparableAscendingComparer<T> : IComparer<T>
		where T: IComparable<T>
	{
		#region Constructors
		public ComparableAscendingComparer()
		{
		}
		#endregion Constructors

		#region Methods
		public int Compare(T x, T y)
		{
			return x.CompareTo(y);
		}
		#endregion Methods
	}
}
