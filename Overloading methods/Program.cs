using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_methods
{
	/// <summary>
	/// Принимает с консоли числа и выводит их абсолютное значение
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			int intX = 0;
			double doubleX = 0;
			long longX = 0;

			Input("Enter int value", ref intX);
			Input("Enter double value", ref doubleX);
			Input("Enter long value", ref longX);

			Console.WriteLine();

			Console.WriteLine("Int module: {0}", Module(intX));
			Console.WriteLine("Double module: {0}", Module(doubleX));
			Console.WriteLine("Long module: {0}", Module(longX));

			Console.ReadKey();
		}
		/// <summary>
		/// Безопасный ввод с консоли числа типа int
		/// </summary>
		/// <param name="text">Используется в качестве приглашения для ввода</param>
		/// <param name="intX">Используется для возврата введенного значения</param>
		static public void Input(string text, ref int intX) 
		{
			while (true)
			{
				Console.Write(text + ": ");
				if(Int32.TryParse(Console.ReadLine(), out intX))
					break;
				Console.WriteLine("Wrong input. Try again\n");
			}
		}
		/// <summary>
		/// Безопасный ввод с консоли числа типа double
		/// </summary>
		/// <param name="text">Используется в качестве приглашения для ввода</param>
		/// <param name="doubleX">Используется для возврата введенного значения</param>
		static public void Input(string text, ref double doubleX)
		{
			while (true)
			{
				Console.Write(text + ": ");
				if (Double.TryParse(Console.ReadLine(), out doubleX))
					break;
				Console.WriteLine("Wrong input. Try again\n");
			}
		}
		/// <summary>
		/// Безопасный ввод с консоли числа типа long
		/// </summary>
		/// <param name="text">Используется в качестве приглашения для ввода</param>
		/// <param name="longX">Используется для возврата введенного значения</param>
		static public void Input(string text, ref long longX)
		{
			while (true)
			{
				Console.Write(text + ": ");
				if (long.TryParse(Console.ReadLine(), out longX))
					break;
				Console.WriteLine("Wrong input. Try again\n");
			}
		}
		/// <summary>
		/// Находит абсолютное значение числа типа int
		/// </summary>
		/// <param name="val"></param>
		/// <returns>Возвращает абсолютное значение параметра val</returns>
		static public int Module (int val){
			if (val < 0)
				return -val;
			return val;
		}
		/// <summary>
		/// Находит абсолютное значение числа типа double
		/// </summary>
		/// <param name="val"></param>
		/// <returns>Возвращает абсолютное значение параметра val</returns>
		static public double Module(double val)
		{
			if (val < 0)
				return -val;
			return val;
		}
		/// <summary>
		/// Находит абсолютное значение числа типа long
		/// </summary>
		/// <param name="val"></param>
		/// <returns>Возвращает абсолютное значение параметра val</returns>
		static public long Module(long val)
		{
			if (val < 0)
				return -val;
			return val;
		}
	}
}
