using System;

namespace MyApplication
{
	class Ex1
	{
		public static void Run()
		{
			int ftn;

			Console.WriteLine("First 10 Natural Numbers:");

			for(ftn = 1; ftn < 11; ftn++)
			{
				Console.Write(" " + ftn);
			}
        }
	}
}