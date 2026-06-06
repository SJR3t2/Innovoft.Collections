using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public sealed class EqualityComparer<T> : IEqualityComparer<T>
		where T:IEquatable<T>
	{
		#region Constructors
		public EqualityComparer()
		{
		}
		#endregion //Constructors

		#region Methods
		public bool Equals(T x, T y)
		{
			return x.Equals(y);
		}

		public int GetHashCode(T value)
		{
			return value.GetHashCode();
		}
		#endregion //Methods
	}
}
