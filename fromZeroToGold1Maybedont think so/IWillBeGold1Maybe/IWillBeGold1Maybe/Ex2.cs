using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWillBeGold1Maybe
{
    internal class Ex2
    {
        public static void Run()
        {
            int ftn;
            int sftn = 0;

            for (ftn = 1; ftn < 11; ftn++)
            {
                sftn = sftn + ftn;
                Console.Write(" " + ftn);
            }
            Console.WriteLine("The Sum is :" + sftn);
        }
    }
}

