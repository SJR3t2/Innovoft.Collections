using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public sealed class CastingEnumerator<T> : IEnumerator<T>
	{
		#region Fields
		private readonly IEnumerator enumerator;
		#endregion //Fields

		#region Constructors
		public CastingEnumerator(IEnumerable enumerable)
		{
			this.enumerator = enumerable.GetEnumerator();
		}

		public CastingEnumerator(IEnumerator enumerator)
		{
			this.enumerator = enumerator;
		}
		#endregion //Constructors

		#region Properties
		public T Current => (T)enumerator.Current;
		object System.Collections.IEnumerator.Current => (T)enumerator.Current;
		#endregion //Properties

		#region Methods
		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return enumerator.MoveNext();
		}

		public void Reset()
		{
			enumerator.Reset();
		}
		#endregion //Metods
	}
}
