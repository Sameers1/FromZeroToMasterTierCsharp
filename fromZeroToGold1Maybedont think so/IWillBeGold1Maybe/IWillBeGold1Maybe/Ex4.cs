using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWillBeGold1Maybe
{
    internal class Ex4
    {
        public static void Run()
        {
            int ftn;
            int sftn = 0;
            Console.WriteLine("Input the 10 numbers :");
            for (ftn = 1; ftn < 10; ftn++)
            {

                int n = Convert.ToInt32(Console.ReadLine());
                sftn = sftn + n;
            }
            int avg = sftn / 10;

            Console.WriteLine("The Sum is :" + sftn);

            Console.WriteLine("The Average is :" + avg);
        }
    }
}
