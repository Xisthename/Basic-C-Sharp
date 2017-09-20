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
    class AddWholeNumbers
    {
        /// <summary>
        /// Delecering some necessary instance variables
        /// </summary>
        private int numInput;
        private int sum = 0;

        /// <summary>
        /// A method that calls on corresponding methods below
        /// </summary>
        public void Start()
        {
            WriteInfoText();
            ReadInput();
            SumNumbers();
            ShowResult();
        }

        /// <summary>
        /// Writes out some info to the user
        /// </summary>
        private void WriteInfoText()
        {
            Console.WriteLine("++++++++++ Summation of whole numbers ++++++++++");
            Console.WriteLine("             Using a for-statement");
            Console.WriteLine();
        }

        /// <summary>
        /// Asks and reads how many values that should be summed up 
        /// </summary>
        private void ReadInput()
        {
            Console.WriteLine("Number of values to sum: ");
            numInput = Input.ReadIntegerConsole();
        }

        /// <summary>
        /// Loops through the amount of values chosen from the user before
        /// While it asks the user for an value and adds it to the sum
        /// </summary>
        private void SumNumbers()
        {
            for (int i = 0; i < numInput; i++)
            {
                Console.WriteLine("The value of number " + (i + 1) + ": ");
                sum += Input.ReadIntegerConsole();
            }
        }

        /// <summary>
        /// Pretty much displays the sum to the user
        /// </summary>
        private void ShowResult()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine();
        }
    }
}
