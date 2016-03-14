using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_methods
{
	/// <summary>
	/// Пример использования метода расширения <see cref = "CollectionToString"/>
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			int number = InputCollectionLength("Number of elements");
			double[] doubleArr = new double[number];

			for (int i = 0; i < number; i++)
				Input(string.Format("doubleArr[{0}]", i), ref doubleArr[i]);
			
			Console.WriteLine(doubleArr.CollectionToString());
			Console.ReadKey();
		}

		/// <summary>
		/// Безопасный ввод с консоли числа элементов коллекции
		/// </summary>
		/// <param name="text">Используется в качестве приглашения для ввода</param>
		/// <returns>Число типа int больше 0</returns>
		static public int InputCollectionLength(string text)
		{
			int number;
			while (true)
			{
				Console.Write(text + ": ");
				if (Int32.TryParse(Console.ReadLine(), out number) && number > 0)
					return number;
				Console.WriteLine("Wrong input. Try again\n");
			}
		}
		/// <summary>
		/// Безопасный ввод с консоли числа с плавающей точкой больше 0
		/// </summary>
		/// <param name="text"></param>
		/// <param name="doubleX"></param>
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
	}
}