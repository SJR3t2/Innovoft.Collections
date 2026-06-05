using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Innovoft.Collections
{
	public sealed class Enumerator2<T> : IEnumerator<T>
	{
		public IEnumerator<IEnumerable<T>> valuess;
		private IEnumerator<T> values;

		public Enumerator2(IEnumerable<IEnumerable<T>> valuess)
		{
			this.valuess = valuess.GetEnumerator();
			this.values = this.valuess.MoveNext() ? this.valuess.Current.GetEnumerator() : null;
		}

		public Enumerator2(IEnumerator<IEnumerable<T>> valuess)
		{
			this.valuess = valuess;
			this.values = this.valuess.MoveNext() ? this.valuess.Current.GetEnumerator() : null;
		}

		~Enumerator2()
		{
			Dispose(disposing: false);
		}

		public T Current => values.Current;

		object IEnumerator.Current => Current;

		public void Dispose()
		{
			Dispose(disposing: true);
		}

		private void Dispose(bool disposing)
		{
			if (!disposing)
			{
				return;
			}

			Interlocked.Exchange(ref values, null)?.Dispose();
			Interlocked.Exchange(ref valuess, null)?.Dispose();
		}

		public bool MoveNext()
		{
			if (values == null)
			{
				return false;
			}
			while (true)
			{
				if (values.MoveNext())
				{
					return true;
				}
				if (!valuess.MoveNext())
				{
					return false;
				}
				values.Dispose();
				values = valuess.Current.GetEnumerator();
				continue;
			}
		}

		public void Reset()
		{
			values?.Dispose();
			valuess.Reset();
			values = valuess.MoveNext() ? valuess.Current.GetEnumerator() : null;
		}

		public void Reset(IEnumerable<IEnumerable<T>> valuess)
		{
			this.values?.Dispose();
			this.valuess.Dispose();
			this.valuess = valuess.GetEnumerator();
			this.values = this.valuess.MoveNext() ? this.valuess.Current.GetEnumerator() : null;
		}

		public void Reset(IEnumerator<IEnumerable<T>> valuess)
		{
			this.values?.Dispose();
			this.valuess.Dispose();
			this.valuess = valuess;
			this.valuess.Reset();
			this.values = this.valuess.MoveNext() ? this.valuess.Current.GetEnumerator() : null;
		}
	}
}
