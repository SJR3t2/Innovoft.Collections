using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Innovoft.Collections
{
	public sealed class NoneEnumerator<T> : IEnumerator<T>
	{
		#region Class Fields
		private static readonly NoneEnumerator<T> singleton = new NoneEnumerator<T>();
		#endregion //Class Fields

		#region Class Fields
		public static NoneEnumerator<T> Singleton => singleton;
		#endregion //Class Fields

		#region Constructors
		public NoneEnumerator()
		{
		}
		#endregion //Constructors

		#region Finalizer
		~NoneEnumerator()
		{
			Dispose(dispose: false);
		}
		#endregion //Finalizer

		#region Properties
		public T Current => default;

		object IEnumerator.Current => null;
		#endregion //Properties

		#region Methods
		#region Disopse
		public void Dispose()
		{
			Dispose(dispose: true);
			GC.SuppressFinalize(this);
		}

		private void Dispose(bool dispose)
		{
		}
		#endregion //Disopse

		public void Reset()
		{
		}

		public bool MoveNext()
		{
			return false;
		}
		#endregion //Methods
	}
}
