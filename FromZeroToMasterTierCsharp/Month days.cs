using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromZeroToMasterTierCsharp
{
    public class casestudy  // Declaration of the exercise23 class
    {
        static void casestudy1(string[] args)  // Main method, entry point of the program
        {
            int monno;  // Declaration of a variable to store the month number

            Console.Write("\n\n");  // Displaying new lines
            Console.Write("Read month number and display number of days for that month:\n");  // Displaying the purpose of the program
            Console.Write("--------------------------------------------------------------");  // Displaying a separator
            Console.Write("\n\n");

            Console.Write("Input Month No : ");  // Prompting user to input a month number
            monno = Convert.ToInt32(Console.ReadLine());  // Reading the input and converting it to an integer

            switch (monno)  // Switch statement based on the entered month number
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.Write("Month has 31 days. \n");  // Displaying that months 1, 3, 5, 7, 8, 10, and 12 have 31 days
                    break;
                case 2:
                    Console.Write("The 2nd month is February and has 28 days. \n");  // Displaying that February has 28 days
                    Console.Write("In leap years, February has 29 days.\n");  // Mentioning that in leap years, February has 29 days
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.Write("Month has 30 days. \n");  // Displaying that months 4, 6, 9, and 11 have 30 days
                    break;
                default:
                    Console.Write("Invalid Month number.\nPlease try again ....\n");  // Handling invalid month numbers
                    break;
            }
        }

    }
}
