using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public sealed class Enumerable2<T> : IEnumerable<T>
	{
		private IEnumerable<IEnumerable<T>> valuess;

		public Enumerable2()
		{
		}

		public Enumerable2(IEnumerable<IEnumerable<T>> valuess)
		{
			this.valuess = valuess;
		}

		public IEnumerable<IEnumerable<T>> Valuess { get => valuess; set => valuess = value; }

		public IEnumerator<T> GetEnumerator()
		{
			var value = new Enumerator2<T>(valuess);
			return value;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
