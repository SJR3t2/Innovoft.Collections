using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public sealed class ComparisonsComparer<T> : IComparer<T>
	{
		#region Fields
		private readonly Comparison<T>[] comparisons;
		#endregion //Fields

		#region Constructors
		public ComparisonsComparer(params Comparison<T>[] comparisons)
		{
			this.comparisons = comparisons;
		}
		#endregion //Constructors

		#region Methods
		public int Compare(T x, T y)
		{
			foreach (var comparison in comparisons)
			{
				var compared = comparison(x, y);
				if (compared != 0)
				{
					return compared;
				}
			}
			return 0;
		}
		#endregion //Methods
	}
}
