using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public sealed class CastingEnumerable<T> : IEnumerable<T>
	{
		#region Fields
		private readonly IEnumerable enumerable;
		#endregion //Fields

		#region Constructors
		public CastingEnumerable(IEnumerable enumerable)
		{
			this.enumerable = enumerable;
		}
		#endregion //Constructors

		#region Methods
		public IEnumerator<T> GetEnumerator()
		{
			var enumerator = new CastingEnumerator<T>(enumerable);
			return enumerator;
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			var enumerator = new CastingEnumerator<T>(enumerable);
			return enumerator;
		}
		#endregion //Methods
	}
}
