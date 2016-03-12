using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_operators
{
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

		public string ToString()
		{
			return string.Format("{0}, {1}, {2})", x, y, z);
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
