using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromZeroToMasterTierCsharp
{
    internal class LowUpCase
    {
        public static void LowUpCase1()
        {
            string sentense;
            Console.WriteLine("Write a sentense to make it all in lower case and upper case.");
            sentense = Console.ReadLine();
            Console.WriteLine(sentense.ToUpper());
            Console.WriteLine(sentense.ToLower());
            Console.Read();
        }
    }

}
