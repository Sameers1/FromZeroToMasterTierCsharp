using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWillBeGold1Maybe
{
    internal class Ex8
    {
        public static void Run()
        {
            int oddS = 0;

            Console.WriteLine("Enter the Length:");
            int lth = Convert.ToInt32(Console.ReadLine());

            for (int r = 1; r <= lth; r++)
            {

                int oddR = r * 2 - 1;
                oddS = oddS + oddR;
                Console.WriteLine(oddR);
            }
            Console.WriteLine($"The Sum of the Odd numbers are: {oddS}");

        }
    }
}
