using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public sealed class ComparableDescendingComparer<T> : IComparer<T>
		where T: IComparable<T>
	{
		#region Constructors
		public ComparableDescendingComparer()
		{
		}
		#endregion Constructors

		#region Methods
		public int Compare(T x, T y)
		{
			return y.CompareTo(x);
		}
		#endregion Methods
	}
}
