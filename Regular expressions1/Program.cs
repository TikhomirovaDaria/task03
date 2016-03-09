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
			Regex loginMask = new Regex(@"^[a-zA-Z][\w]{1,9}$");
			string login;

			Console.Write("Enter login: ");
			login = Console.ReadLine();

			Console.WriteLine(loginMask.IsMatch(login));
			Console.ReadKey();
		}
	}
}
