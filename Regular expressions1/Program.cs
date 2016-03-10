using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regular_expressions1
{
	class Program
	{
		static void Main(string[] args)
		{
			Regex loginMask = new Regex(@"^[a-z][a-z\d]{1,9}$", RegexOptions.IgnoreCase);
			string login;

			do
			{
				Console.Clear();
				Console.Write("Enter login: ");
				login = Console.ReadLine();

				Console.WriteLine(loginMask.IsMatch(login));
				Console.Write("\nEnter Esc to exit or any other button to continue ");

			} while (Console.ReadKey().Key != ConsoleKey.Escape);

			
		}
	}
}
