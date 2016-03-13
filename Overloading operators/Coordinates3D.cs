using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_operators
{
	/// <summary>
	/// Описывает точку как совокупность 3 координат типа int
	/// </summary>
	class Coordinates3D
	{
		int x;
		int y;
		int z;

		/// <summary>
		/// Конструктор по умолчанию.
		/// Инициализирует поля класса <see = cref "Coordinates3D"/> нулями
		/// </summary>
		public Coordinates3D()
		{
			x = 0;
			y = 0;
			z = 0;
		}
		/// <summary>
		/// Конструктор
		/// Инициализирует поля класса <see = cref "Coordinates3D"/> заданными значениями
		/// </summary>
		public Coordinates3D(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}
		/// <summary>
		/// Представлят поля класса <see = cref "Coordinates3D"/> в виде строки
		/// </summary>
		public string ToString()
		{
			return string.Format("({0}, {1}, {2})", x, y, z);
		}

		/// <summary>
		/// Покоорднатное сложение двух точек 
		/// </summary>
		/// <param name="d1"></param>
		/// <param name="d2"></param>
		/// <returns>Возвращает экземпляр класса <see = cref "Coordinates3D"/> 
		/// поля которого проинициализирваны суммой соответствующих координат точек d1 и d2</returns></returns>
		public static Coordinates3D operator +(Coordinates3D d1, Coordinates3D d2)
		{
			return new Coordinates3D(d1.x + d2.x, d1.y + d2.y, d1.z + d2.z);
		}
		/// <summary>
		/// Покоорднатная вычитание двух точек 
		/// </summary>
		/// <param name="d1"></param>
		/// <param name="d2"></param>
		/// <returns>Возвращает экземпляр класса <see = cref "Coordinates3D"/> 
		/// поля которого проинициализирваны разностью соответствующих координат точек d1 и d2</returns>
		public static Coordinates3D operator -(Coordinates3D d1, Coordinates3D d2)
		{
			return new Coordinates3D(d1.x - d2.x, d1.y - d2.y, d1.z - d2.z);
		}
	}
}
