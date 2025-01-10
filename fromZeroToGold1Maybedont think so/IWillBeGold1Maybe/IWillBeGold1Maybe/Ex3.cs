using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWillBeGold1Maybe
{
    internal class Ex3
    {
        public static void Run()
        {
            int ftn;
            int sftn = 0;
            Console.WriteLine("Enter the Length:");
            int lth = Convert.ToInt32(Console.ReadLine());

            for (ftn = 1; ftn < lth; ftn++)
            {
                sftn = sftn + ftn;
                Console.Write(" " + ftn);
            }
            Console.WriteLine("The Sum is :" + sftn);
        }
    }
}
