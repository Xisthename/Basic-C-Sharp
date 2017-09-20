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
    class CurrencyConverter
    {
        /// <summary>
        /// Delecering some necessary instance variables
        /// </summary>
        private double sum;
        private double rate;
        private double value;
        private String name;

        /// <summary>
        /// Calls on corresponding methods below
        /// </summary>
        public void Start()
        {
            WriteInfoText();
            SumNumbers();
            WhatCurrencyAndRate();
            ConvertSum();
            ShowResult();
        }

        /// <summary>
        /// Writes out some info to the user
        /// </summary>
        private void WriteInfoText()
        {
            Console.WriteLine("++++++++++ The Currency Converter real numbers ++++++++++");
            Console.WriteLine();
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
        /// Reads in a input of a double value
        /// If the value is not 0 it adds the value to the sum
        /// If the value is 0 or close to 0 it ends the loop
        /// </summary>
        private void SumNumbers()
        {
            double num;
            do
            {
                num = ReadInput();
                sum += num;
            }
            while (Math.Round(num, 7) != 0);
        }

        /// <summary>
        /// Asks the user and stores the name and the exchange rate
        /// </summary>
        private void WhatCurrencyAndRate()
        {
            Console.WriteLine("Name of the foreign currency: ");
            name = Console.ReadLine();
            Console.WriteLine("Exchange rate: ");
            rate = Input.ReadDoubleConsole();
        }

        /// <summary>
        /// Stores how much the sum is worth in the other currency
        /// </summary>
        private void ConvertSum()
        {
            value = sum / rate;
        }

        /// <summary>
        /// Displays the sum, value, name and rate so that the user understands how much their
        /// money is worth in the other currency
        /// </summary>
        private void ShowResult()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine();
            Console.WriteLine(sum + " is converted to " + value + " " + name + " at the rate of " + rate + " kr/" + name);
        }
    }
}
