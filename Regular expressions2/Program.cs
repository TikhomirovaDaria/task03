using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regular_expressions2
{
	/// <summary>
	/// Поиск в исходном тексте слова «металл» и его однокоренных слов,
	/// а также их вывод на консоль.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			Regex metallMask = new Regex(@"\b[-\w]*(металл)[-\w]*\b", RegexOptions.IgnoreCase);
			System.IO.StreamReader file = new System.IO.StreamReader(@"../../Metall.txt", Encoding.Default);
			string text = file.ReadToEnd();

			Match foundWords = metallMask.Match(text);

			if (!foundWords.Success)
			{
				Console.WriteLine("No matches");
				Console.ReadKey();
				return;
			}

			while (foundWords.Success)
			{
				Console.WriteLine(foundWords);
				foundWords = foundWords.NextMatch();
			}
			
			Console.ReadKey();
		}
	}
}
