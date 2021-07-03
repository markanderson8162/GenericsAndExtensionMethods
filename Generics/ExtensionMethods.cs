using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
	static class ExtensionMethods
	{
		public static IEnumerable<int> FindOdds<IEnumerable>(IEnumerable<int> i)
		{
			return i.Where(e => e % 2 == 1);
		}

		public static T[] SortArray<T>(T[] f)
		{
			return f.OrderBy(e => e).ToArray();
		}
	}
}
