using System;
using System.Runtime.Intrinsics.X86;

namespace daborg69
{
	// Next Version
	public class Core
	{
		private int x = 0;
		private int y = 0;
		private int z = 0;
		private int a = 0;


		public Core()
		{
			Console.WriteLine("hello");

			x++;
			y++;
			y++;
			y += 2;
			y++;
			y = y * y;
			y++;

			z += 2;
			z += 4;
			z += 4;
			z = z * z;
			z = z * z;


			a += 50;
			a += x;
			a += a * x;
			a += a * x;
			a += x; a++;
			a = a * a;
			a += z;
			a += 2;
			a++;
			a = a * 2;
		}


		public int ValueA() { return a; }
		public void ResetA() { a = 0; }

		public int ValueX() { return x; }
	}
}
