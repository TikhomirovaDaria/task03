using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_methods
{
	class Program
	{
		static void Main(string[] args)
		{
			// пример использования IListToString
			int number = Input("Number of elements");
			double[] doubleArr = new double[number];

			for (int i = 0; i < number; i++)
				Input(string.Format("doubleArr[{0}]", i), ref doubleArr[i]);
			
			Console.WriteLine(doubleArr.CollectionToString());
			Console.ReadKey();
		}

		static public int Input(string text)
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