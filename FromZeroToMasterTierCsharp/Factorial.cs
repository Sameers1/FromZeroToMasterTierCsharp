using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromZeroToMasterTierCsharp
{
    internal class Factorials
    {
        public static void Factorial()
        {
            int value = 6;

            int result = 1;
            int finalR = 0;

            for (int i = 1; i <= 6; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);
        }
    }

}
