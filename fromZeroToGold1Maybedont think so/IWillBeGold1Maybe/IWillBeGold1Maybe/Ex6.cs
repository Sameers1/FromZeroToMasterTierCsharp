using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWillBeGold1Maybe
{
    internal class Ex6
    {
       public static void Run()
        {
            int sftn = 0;
            Console.WriteLine("Enter the Length:");
            int lth = Convert.ToInt32(Console.ReadLine());

            for (int ftn = 1; ftn <= 10; ftn++)
            {
                sftn = lth * ftn;
                Console.WriteLine($"{lth} X {ftn} = {sftn}");
            }

        }
    }
}
