using System;

namespace Tarea_For
{
	class Program
	{
		static void Main(string[] args)
		{
			int x, y, z;
			Console.WriteLine("De donde arrancamos el ciclo: ");
			x = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Hasta donde terminamos el ciclo el ciclo:");
			y = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("De cuanto en cuanto? ");
			z = Convert.ToInt32(Console.ReadLine());

			if (x < y)
			{
				for (int i = x; i <= y; i += z)
				{
					Console.WriteLine("i = " + i);
				}
			}
			if (x > y)
			{
				for (int i = x; i >= y; i -= z)
				{
					Console.WriteLine("i = " + i);
				}
			}
		}
	}
}