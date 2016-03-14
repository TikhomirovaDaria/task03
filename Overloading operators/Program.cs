using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_operators
{
	/// <summary>
	/// Организует работу экземплярами класса <see = cref "Coordinates3D"/> 
	/// Вывдит результаты работы переруженных операторов сложения и вычитания
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			int[,] inputCoord = new int[2,3];

			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 3; j++)
					inputCoord[i, j] = Input("Coordinate dot " + (i+1) + " [" + j + "]");
				Console.WriteLine("\n");
			}


			Coordinates3D dot1 = new Coordinates3D(inputCoord[0, 0], inputCoord[0, 1], inputCoord[0, 2]);
			Coordinates3D dot2 = new Coordinates3D(inputCoord[1, 0], inputCoord[1, 1], inputCoord[1, 2]);

			Console.Clear();
			Console.WriteLine("DOT 1 = " + dot1.ToString());
			Console.WriteLine("DOT 2 = " + dot2.ToString());
			Console.WriteLine("DOT 3 = DOT 1 + DOT 2 = " + (dot1+dot2).ToString());
			Console.WriteLine("DOT 4 = DOT 1 - DOT 2 = " + (dot1 - dot2).ToString());
			
			Console.ReadKey();
		}

		/// <summary>
		/// Безопаснй ввод с консоли числа типа int
		/// </summary>
		/// <param name="text">Используется в качестве приглашения для ввода</param>
		static int Input(string text)
		{
			int input;

			while (true)
			{
				Console.Write(text + ": ");
				if (Int32.TryParse(Console.ReadLine(), out input))
					return input;
				Console.WriteLine("Wrong input. Try again\n");
			}
		}
	}
}
