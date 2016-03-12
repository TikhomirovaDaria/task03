using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_methods
{
	static class ExtensionMethodClass
	{
		public static string CollectionToString<T>(this IList<T> element)
		{
			StringBuilder result = new StringBuilder();

			for (int i = 0; i < element.Count - 1; i++)
				result.AppendFormat("{0}, ", element[i]);
			result.Append(element[element.Count - 1]);
			
			return result.ToString();
		}
	}
}
