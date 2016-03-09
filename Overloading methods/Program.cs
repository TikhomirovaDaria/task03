using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_methods
{
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

		static public void Input(string text, ref int intX) 
		{
			while (true)
			{
				Console.Write(text + ": ");
				try
				{
					intX = int.Parse(Console.ReadLine());
					break;
				}
				catch (FormatException)
				{
					Console.WriteLine("Wrong input. Try again\n");
				}
			}
		}
		static public void Input(string text, ref double doubleX)
		{
			while (true)
			{
				Console.Write(text + ": ");
				try
				{
					doubleX = double.Parse(Console.ReadLine());
					break;
				}
				catch (FormatException)
				{
					Console.WriteLine("Wrong input. Try again\n");
				}
			}
		}
		static public void Input(string text, ref long longX)
		{
			while (true)
			{
				Console.Write(text + ": ");
				try
				{
					longX = long.Parse(Console.ReadLine());
					break;
				}
				catch (FormatException)
				{
					Console.WriteLine("Wrong input. Try again\n");
				}
			}
		}

		static public int Module (int val){
			if (val < 0)
				return val * (-1);
			return val;
		}
		static public double Module(double val)
		{
			if (val < 0)
				return val * (-1);
			return val;
		}
		static public long Module(long val)
		{
			if (val < 0)
				return val * (-1);
			return val;
		}
	}
}
