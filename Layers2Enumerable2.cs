using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public sealed class Layers2Enumerable2<T> : IEnumerable<T>
	{
		private IEnumerable<IEnumerable<T>> valuess;

		public Layers2Enumerable2()
		{
		}

		public Layers2Enumerable2(IEnumerable<IEnumerable<T>> valuess)
		{
			this.valuess = valuess;
		}

		public IEnumerable<IEnumerable<T>> Valuess { get => valuess; set => valuess = value; }

		public IEnumerator<T> GetEnumerator()
		{
			var value = new Layers2Enumerator2<T>(valuess);
			return value;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
