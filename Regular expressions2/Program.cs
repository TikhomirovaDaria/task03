using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regular_expressions2
{
	class Program
	{
		static void Main(string[] args)
		{
			// как понимать "однокоренные"? Мы не можем распознать, существует реально ли заданное слово или нет
			// сделала единтвенным ограничением цифры, т.е., например, "9металл" или "меллический19328" - не подойдут

			Regex metallMask = new Regex(@"\b[\w-[\d]]*([мМ][еЕ][тТ][аА][лЛ][лЛ])[\w-[\d]]*\b");
			string text;

			Console.Write("Enter text: ");
			text = Console.ReadLine();

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
