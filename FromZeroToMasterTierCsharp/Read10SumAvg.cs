using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FromZeroToMasterTierCsharp
{
    internal class ReadSumAvgs
    {
        public static void ReadSumAvg()
        {
           double sum = 0;
            Console.WriteLine("Type 10 digits:");
            
            for (int i = 0; i < 3; i++)
            {
               sum += Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Sum and avg is :{0} and {1} ",sum,sum/3);
             
        }

    }

}
