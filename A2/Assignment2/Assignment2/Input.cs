using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// Daniel Petersén
    /// 2017-09-06
    /// </summary>
    class Input
    {
        /// <summary>
        /// Delecering a static error message
        /// </summary>
        private static String errorText = "Wrong input! Please try again: ";

        /// <summary>
        /// Trys to convert the input from the user to an int
        /// If it succeeded the method returns the int
        /// It it fails it writes out the error message and does the same procedure all over again
        /// </summary>
        /// <returns></returns>
        public static int ReadIntegerConsole()
        {
            int input;

            if (int.TryParse(Console.ReadLine(), out input))
            {
                return input;
            }
            else
            {
                Console.WriteLine(errorText);
                return ReadIntegerConsole();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Temp()
        {
            return 5;
        }

        /// <summary>
        /// Trys to convert the input from the user to a double
        /// If it succeeded the method returns the a double
        /// It it fails it writes out the error message and does the same procedure all over again
        /// </summary>
        /// <returns></returns>
        public static double ReadDoubleConsole()
        {
            double input;

            if (double.TryParse(Console.ReadLine(), out input))
            {
                return input;
            }
            else
            {
                Console.WriteLine(errorText);
                return ReadDoubleConsole();
            }
        }
    }
}
