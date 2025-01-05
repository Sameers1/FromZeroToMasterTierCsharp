using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromZeroToMasterTierCsharp
{
    internal class OddNumbers
    {
        public static void OddNumber()
        {
            int settLimit, number=0;
            int count = 0;
            Console.WriteLine("Set a Number till you want to show odd numbers to:");
            settLimit = int.Parse(Console.ReadLine());
            while (number <= settLimit)
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine(number);
                    count++;
                }
                number++;

            }
            Console.WriteLine($"There are {count} odd numbers in {settLimit}.");
        }
    }

}
