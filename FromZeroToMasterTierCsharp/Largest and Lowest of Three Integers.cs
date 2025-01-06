using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromZeroToMasterTierCsharp
{
    internal class LargestAndLowests
    {
        public static void LargestAndLowest()
        {
            int number1, number2, number3;

            Console.Write("\nInput the First Number : ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("\nInput the Second Number : ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("\nInput The Third number : ");
            number3 = int.Parse(Console.ReadLine());

            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine($"Largest of 3 = {number1}");
            }
            else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine($"Largest of 3 = {number2}");

            }
            else if (number3 > number1 && number3 > number2)
            {
                Console.WriteLine($"Largest of 3 = {number3}");

            }

            if (number1 < number2 && number1 < number3)
            {
                Console.WriteLine($"Lowest of 3 = {number1}");
            }
            else if (number2 < number1 && number2 < number3)
            {
                Console.WriteLine($"Lowest of 3 = {number2}");

            }
            else if (number3 < number1 && number3 < number2)
            {
                Console.WriteLine($"Lowest of 3 = {number3}");

            }


        }
    }

}
