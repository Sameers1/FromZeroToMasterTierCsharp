using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FromZeroToMasterTierCsharp
{
    internal class RemoveStrings
    {
        public static void RemoveString()
        {
            string reword = string.Empty;
            string word = "PHP Tutorial";
            Console.WriteLine($"Removing Hp from -{word}-");
            reword = word.Remove(1, 2);
            Console.WriteLine(reword);

        }
    }

}
