using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FromZeroToMasterTierCsharp
{
    internal class CheckWs
    {
        public static void CheckW()
        {

            //            Write a C# program to check if a given string contains the 'w' character between 1 and 3 times.
            //Test Data:
            //            Input a string(contains at least one 'w' char) : w3resource
            //            Test the string contains 'w' character between 1 and 3 times:
            //            Sample Output
            //True
            bool result;
            Console.WriteLine("Write a Word");
            string str = Console.ReadLine();
            char[] words = str.ToCharArray();
            int count = 0;
            foreach (char c in words)
            {
                if (c == 'w')
                {
                    count++;
                }
            }

            if (count >= 1 && count <= 3)
            {
                result = true;
                Console.WriteLine(result);            
            }
            else
            {
                result = false;
                Console.WriteLine(result);
            }


        }
    }

}
