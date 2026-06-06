using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public sealed class ConverterEnumerator<TInput, TOutput> : IEnumerator<TOutput>
	{
		#region Fields
		private readonly IEnumerator<TInput> enumerator;
		private readonly Converter<TInput, TOutput> converter;
		private TOutput current;
		#endregion Fields

		#region Constructors
		public ConverterEnumerator(IEnumerable<TInput> enumerable, Converter<TInput, TOutput> converter)
		{
			this.enumerator = enumerable.GetEnumerator();
			this.converter = converter;
		}
		#endregion Constructors

		#region Properties
		public TOutput Current { get { return current; } }
		object System.Collections.IEnumerator.Current { get { return current; } }
		#endregion Properties

		#region Methods
		public void Dispose()
		{
			enumerator.Dispose();
		}

		public bool MoveNext()
		{
			if (!enumerator.MoveNext())
			{
				current = default(TOutput);
				return false;
			}
			else
			{
				current = converter(enumerator.Current);
				return true;
			}
		}

		public void Reset()
		{
			enumerator.Reset();
		}
		#endregion Methods
	}
}
