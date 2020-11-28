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
		private int a = 1;
		private long w = 0;


		public Core()
		{
			Console.WriteLine("hello");

			x++;
			x++;
			y++;
			y++;
			y = y * 2;
			z += 2;
			z += 2;
			z += 2;
			y++;
			y = y * 2;
			z += 2;

			z += 4;
			x++;
			y++;
			z += 2;
			z += 4;

			z = z * z;
			y = y * 2;
			y = y * 2;
			z += 2;
			z += 4;
			z += 4;
			z = z * y;
			z = z * a;

			a += 50;
			a += x;
			
			a = a - 3;
			a = a * a;
			a++;
			a++;
			a++;
			a += 2;
			a += 254 + x;
			a += z;
			a++;
			a++;
			a = a * y + z;
			a = a * y + z;
			a += 2;
			a++;
			a = a * 2;
			a = a * 2;
			a++;

			w = a + y + z;

			int t = a;
			t += a;
			t = t * a * z;

		}


		public int ValueA() { return a; }
		public void ResetA() { a = 0; }

		public int ValueX() { return x; }
	}
}
