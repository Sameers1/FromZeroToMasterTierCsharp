using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWillBeGold1Maybe
{
    internal class Ex10
    {
        public static void Run()
        {
            Console.WriteLine("Enter the Length:");
            int lth = Convert.ToInt32(Console.ReadLine());

            for (int row = 1; row <= lth; row++)
            {
                for (int colm = 1; colm <= row; colm++)
                {
                    Console.Write($" {colm}");
                }
                Console.Write("\n");
            }
        }
    }
}
