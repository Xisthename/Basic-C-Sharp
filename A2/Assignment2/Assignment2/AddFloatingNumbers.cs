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
    class AddFloatingNumbers
    {
        /// <summary>
        /// Delecering a necessary instance variable
        /// </summary>
        private double sum = 0;

        /// <summary>
        /// A method that calls on corresponding methods below
        /// </summary>
        public void Start()
        {
            WriteInfoText();
            SumNumbers();
            ShowResult();
        }

        /// <summary>
        /// Writes out some info to the user
        /// </summary>
        private void WriteInfoText()
        {
            Console.WriteLine("++++++++++ Summation of real numbers ++++++++++");
            Console.WriteLine("             Using a While-statement");
            Console.WriteLine("Write 0 to finish!");
            Console.WriteLine("Make sure to use the correct decimal characater!");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
        }

        /// <summary>
        /// Asks and returns the double written by the user
        /// </summary>
        /// <returns></returns>
        private double ReadInput()
        {
            Console.WriteLine("Write an amount to sum or zero to finish: ");
            return Input.ReadDoubleConsole();
        }

        /// <summary>
        /// An endless loop that goes on forever
        /// Gets the input of a double value
        /// If the value is not 0 it adds the value to the sum
        /// If the value is 0 or close to 0 it breaks out of the endless loop
        /// </summary>
        private void SumNumbers()
        {
            while (true)
            {
                double num = ReadInput();

                if (Math.Round(num, 7) != 0)
                {
                    sum += num;
                }
                else
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Displays the result of the sum to the user
        /// </summary>
        private void ShowResult()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine();
        }
    }
}
