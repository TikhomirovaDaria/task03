using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_operators
{
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
			Coordinates3D dot3 = dot1 + dot2;
			Coordinates3D dot4 = dot1 - dot2;

			Console.Clear();
			dot1.Print("DOT 1");
			dot2.Print("DOT 2");
			dot3.Print("DOT 3 = DOT 1 + DOT 2");
			dot4.Print("DOT 4 = DOT 1 - DOT 2");
			Console.ReadKey();

		}

		static int Input(string text)
		{
			int input;

			while (true)
			{
				Console.Write(text + ": ");
				try
				{
					input = int.Parse(Console.ReadLine());
					return input;
				}
				catch (FormatException)
				{
					Console.WriteLine("Wrong input. Try again\n");
				}
			}
		}
	}

	class Coordinates3D
	{
		int x;
		int y;
		int z;

		public Coordinates3D()
		{
			x = 0;
			y = 0;
			z = 0;
		}
		public Coordinates3D(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public void Print(string text) 
		{
			Console.WriteLine(text + "\n");
			Console.WriteLine(	"x = " + x);
			Console.WriteLine(	"y = " + y);
			Console.WriteLine(	"z = " + z);
			Console.WriteLine("\n\n");
		}
		

		public static Coordinates3D operator +(Coordinates3D d1, Coordinates3D d2)
		{
			return new Coordinates3D(d1.x + d2.x, d1.y + d2.y, d1.z + d2.z);
		}
		public static Coordinates3D operator -(Coordinates3D d1, Coordinates3D d2)
		{
			return new Coordinates3D(d1.x - d2.x, d1.y - d2.y, d1.z - d2.z);
		}

	}
}
