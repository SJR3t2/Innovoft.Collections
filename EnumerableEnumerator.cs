using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Innovoft.Collections
{
	public sealed class EnumerableEnumerator<T> : IEnumerator<T>
	{
		#region Fields
		private readonly IEnumerator<IEnumerable<T>> enumerables;
		private IEnumerator<T> enumerator;
		#endregion Fields

		#region Constructors
		public EnumerableEnumerator(IEnumerable<IEnumerable<T>> enumerables)
		{
			this.enumerables = enumerables.GetEnumerator();
		}
		#endregion Constructors

		#region Properties
		public T Current => enumerator.Current;

		object System.Collections.IEnumerator.Current => enumerator.Current;
		#endregion Properties

		#region Methods
		public void Dispose()
		{
			Interlocked.Exchange(ref enumerator, null)?.Dispose();
			enumerables.Dispose();
		}

		public bool MoveNext()
		{
			while (true)
			{
				if (enumerator != null)
				{
					if (enumerator.MoveNext())
					{
						return true;
					}

					enumerator.Dispose();
					enumerator = null;
				}

				while (true)
				{
					if (!enumerables.MoveNext())
					{
						return false;
					}

					var enumerable = enumerables.Current;
					if (enumerable == null)
					{
						continue;
					}

					enumerator = enumerable.GetEnumerator();
					break;
				}
			}
		}

		public void Reset()
		{
			Interlocked.Exchange(ref enumerator, null)?.Dispose();
			enumerables.Reset();
		}
		#endregion Methods
	}
}
