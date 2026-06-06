using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public sealed class ConverterEnumerable<TInput, TOutput> : IEnumerable<TOutput>
	{
		#region Fields
		private readonly IEnumerable<TInput> enumerable;
		private readonly Converter<TInput, TOutput> converter;
		#endregion Fields

		#region Constructors
		public ConverterEnumerable(IEnumerable<TInput> enumerable, Converter<TInput, TOutput> converter)
		{
			this.enumerable = enumerable;
			this.converter = converter;
		}
		#endregion Constructors

		#region Methods
		public IEnumerator<TOutput> GetEnumerator()
		{
			var enumerator = new ConverterEnumerator<TInput, TOutput>(enumerable, converter);
			return enumerator;
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			var enumerator = new ConverterEnumerator<TInput, TOutput>(enumerable, converter);
			return enumerator;
		}
		#endregion Methods
	}
}
