using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    /// <summary>
    /// Prompts the user for 2 numbers and performs simple mathematical functions
    /// and then displays the result back to the user.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number to add: ");
            //Stores value entered into an int
            int iInput1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPlease enter another number to add: ");
            //Stores value entered into an int
            int iInput2 = Convert.ToInt32(Console.ReadLine());

            //Prints result of several mathematical functions
            Console.WriteLine(iInput1 + " + " + iInput2 + " = " + (iInput1 + iInput2));
            Console.WriteLine(iInput1 + " - " + iInput2 + " = " + (iInput1 - iInput2));
            Console.WriteLine(iInput1 + " * " + iInput2 + " = " + (iInput1 * iInput2));
            Console.WriteLine(iInput1 + " / " + iInput2 + " = " + (iInput1 / iInput2));
            Console.WriteLine(iInput1 + " % " + iInput2 + " = " + (iInput1 % iInput2) + "\n\n");

            //Prints whether one value is greater than, equal to or less than the other
            if (iInput1 > iInput2)
            {
                Console.WriteLine("{0} is not less than {1}", iInput1, iInput2);
                Console.WriteLine("{0} is greater than {1}", iInput1, iInput2);
                Console.WriteLine("{0} does not equal {1}", iInput1, iInput2);
            }
            else if (iInput1 == iInput2)
            {
                Console.WriteLine("{0} is not less than {1}", iInput1, iInput2);
                Console.WriteLine("{0} is not greater than {1}", iInput1, iInput2);
                Console.WriteLine("{0} is equal {1}", iInput1, iInput2);
            }
            else
            {
                Console.WriteLine("{0} is not less than {1}", iInput2, iInput1);
                Console.WriteLine("{0} is greater than {1}", iInput2, iInput1);
                Console.WriteLine("{0} does not equal {1}", iInput2, iInput1);
            }
            Console.ReadLine();
        }
    }
}
