using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public sealed class EnumerableEnumerable<T> : IEnumerable<T>
	{
		#region Fields
		private IEnumerable<IEnumerable<T>> enumerables;
		#endregion Fields

		#region Constructors
		public EnumerableEnumerable(IEnumerable<IEnumerable<T>> enumerables)
		{
			this.enumerables = enumerables;
		}

		public EnumerableEnumerable(params IEnumerable<T>[] enumerables)
		{
			this.enumerables = enumerables;
		}
		#endregion Constructors

		#region Methods
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			var enumerator = new EnumerableEnumerator<T>(enumerables);

			return enumerator;
		}

		public IEnumerator<T> GetEnumerator()
		{
			var enumerator = new EnumerableEnumerator<T>(enumerables);

			return enumerator;
		}
		#endregion Methods
	}
}
