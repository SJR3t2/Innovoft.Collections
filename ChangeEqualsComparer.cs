using System;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public sealed class ChangeEqualsComparer<T> : IComparer<T>
	{
		#region Fields
		private readonly Comparison<T> comparison;
		private readonly int change;
		#endregion Fields

		#region Constructors
		public ChangeEqualsComparer(Comparison<T> comparison, int change)
		{
			this.comparison = comparison;
			this.change = change;
		}

		public ChangeEqualsComparer(IComparer<T> comparer, int change)
		{
			this.comparison = comparer.Compare;
			this.change = change;
		}
		#endregion Constructors

		#region Properties
		public Comparison<T> Comparison => comparison;
		public int Change => change;
		#endregion Properties

		#region Methods
		public int Compare(T x, T y)
		{
			var compared = comparison(x, y);
			if (compared == 0)
			{
				return change;
			}
			else
			{
				return compared;
			}
		}
		#endregion Methods
	}
}
