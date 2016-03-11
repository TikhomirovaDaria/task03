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

			while (true)
			{
				Console.Clear();
				Console.Write("Press:\n" +
								  "1 to add logins by yoursels\n" +
								  "2 to get logins out of file\n" +
								  "0 to exit\n\n" +
								  "Your choice: ");

				switch (Console.ReadKey().KeyChar)
				{
					case '0':
						return;
					case '1':
						UserInput(loginMask);
						break;

					case '2':
						FileInput(loginMask);
						break;

					default:
						Console.WriteLine("\n\nWrong input. Try again");
						Console.ReadKey();
						break;
				}
			}
		}

		static void UserInput(Regex loginMask)
		{
			Console.Clear();

			string login;

			do
			{
				Console.Clear();
				Console.Write("Enter login: ");
				login = Console.ReadLine();

				if (loginMask.IsMatch(login))
					PrintColorText("Login \"" + login + "\" is valid", ConsoleColor.Green);
				else
					PrintColorText("Login \"" + login + "\" is invalid", ConsoleColor.Red);
				Console.Write("\nEnter Esc to exit or any other button to continue ");

			} while (Console.ReadKey().Key != ConsoleKey.Escape);

		}
		static void FileInput(Regex loginMask)
		{
			Console.Clear();

			string login;
			System.IO.StreamReader file = new System.IO.StreamReader(@"../../Logins.txt");

			if ((login = file.ReadLine()) == null)
			{
				Console.WriteLine("Document is empty\n");
				Console.ReadKey();
				return;
			}

			do
			{
				if (loginMask.IsMatch(login))
					PrintColorText("Login \"" + login + "\" is valid", ConsoleColor.Green);
				else
					PrintColorText("Login \"" + login + "\" is invalid", ConsoleColor.Red);
			} while ((login = file.ReadLine()) != null);

			Console.ReadKey();
		}
		static void PrintColorText(string text, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.WriteLine(text);
			Console.ResetColor();
		}
	}
}
