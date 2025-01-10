using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWillBeGold1Maybe
{
    internal class Ex7
    {
        public static void Run()
        {
            Console.WriteLine("Enter the Length:");
            int lth = Convert.ToInt32(Console.ReadLine());

            for (int row = 1; row <= 10; row++)
            {
                for (int colm = 1; colm <= lth; colm++)
                {
                    Console.Write($"{colm} x {row} = {colm * row}\t");
                }
            }
            Console.WriteLine();    

        }
    }
}
