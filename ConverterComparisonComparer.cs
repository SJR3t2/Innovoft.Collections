using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public sealed class ConverterComparisonComparer<TInput, TOutput> : IComparer<TInput>
	{
		#region Fields
		private readonly Converter<TInput, TOutput> converter;
		private readonly Comparison<TOutput> comparison;
		#endregion //Fields

		#region Constructors
		public ConverterComparisonComparer(Converter<TInput, TOutput> converter, Comparison<TOutput> comparison)
		{
			this.converter = converter;
			this.comparison = comparison;
		}

		public ConverterComparisonComparer(Converter<TInput, TOutput> converter, IComparer<TOutput> comparer)
		{
			this.converter = converter;
			this.comparison = comparer.Compare;
		}
		#endregion //Constructors

		#region Properties
		public Converter<TInput, TOutput> Converter => converter;
		public  Comparison<TOutput> Comparison => comparison;
		#endregion //Properties

		#region Methods
		public int Compare(TInput x, TInput y)
		{
			return comparison(converter(x), converter(y));
		}
		#endregion //Methods
	}
}
