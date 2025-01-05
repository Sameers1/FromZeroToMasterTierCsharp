using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromZeroToMasterTierCsharp
{
    internal class StringManipulations
    {
        public static void stringmanipulation()
        {
            string line, word = "";
            Console.WriteLine("Write a stentense:");
            line = Console.ReadLine();
            string[] words = line.Split(new[] {' '},StringSplitOptions.None);
             int longestWord = 0;
            foreach(String s in words)
            {
                if (s.Length > longestWord)
                {
                    word = s;
                    longestWord = s.Length;
                }
            }
            Console.WriteLine(word);
            Console.WriteLine(word);

        }
    }

}
