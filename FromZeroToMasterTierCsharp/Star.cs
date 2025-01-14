using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromZeroToMasterTierCsharp
{
    internal class Stars
    {
        public static void Star()
        {
            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                 Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine("_____________________________________________");


            for (int a = 1; a <= 6; a++)
            {
                for (int b = 1; b < a; b++)
                {
                    Console.Write(a);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("_____________________________________________");

           int val = 0;
            for (int c = 1; c <= 6; c++)
            {
                for (int d = 1; d < c; d++)
                {
                    val = val + 1;
                    Console.Write(val);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("_____________________________________________");




        }
    }

}
