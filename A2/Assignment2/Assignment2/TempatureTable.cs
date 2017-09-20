using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// Daniel Petersén
    /// 2017-09-07
    /// </summary>
    class TempatureTable
    {
        /// <summary>
        /// A small Menu that gives the user the option of showing the table C to F or F to C
        /// And of course the option of going back to the Main Menu
        /// </summary>
        public void Start()
        {
            WriteInfoText();
            int choice = -1;

            while (choice != 0)
            {
                WriteMenuText();
                choice = Input.ReadIntegerConsole();
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        CelsiusToFahrenheit();
                        break;
                    case 2:
                        FahrenheitToCelsius();
                        break;
                }
            }
        }

        /// <summary>
        /// Writes out info to the user
        /// </summary>
        private void WriteInfoText()
        {
            Console.WriteLine("                 Tempature Table");
            Console.WriteLine("Select C to F or ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
        }

        /// <summary>
        /// Writes out valuable info how to select from the Menu
        /// </summary>
        private void WriteMenuText()
        {
            Console.WriteLine("1 Celsius (C) to Fahrenheit (F)");
            Console.WriteLine("2 Fahrenheit (F) to Celsius (C)");
            Console.WriteLine("0 Return to Main Menu");
            Console.WriteLine();
            Console.WriteLine("Your choice: ");
        }

        /// <summary>
        /// Tells the user and the method 'WriteTable' which is called upon that the output will be C to F
        /// </summary>
        private void CelsiusToFahrenheit()
        {
            Console.WriteLine("Celsius (C) to Fahrenheit (F)");
            WriteTable(true);
        }

        /// <summary>
        /// Tells the user and the method 'WriteTable' which is called upon that the output will be F to C
        /// </summary>
        private void FahrenheitToCelsius()
        {
            Console.WriteLine("Fahrenheit (F) to Celsius (C)");
            WriteTable(false);
        }

        /// <summary>
        /// Loops through (100/4) 25 times and converts the index value to C to F or F to C
        /// depending on the value of the boolean cToF
        /// It also writes out the list to the user
        /// </summary>
        /// <param name="cToF"></param>
        private void WriteTable(bool cToF)
        {
            for (int i = 0; i <= 100; i+=4)
            {
                if (cToF)
                {
                    int toFahrenheit = (int) (Math.Round(9.0 / 5.0 * i + 32.0));
                    Console.WriteLine(i + " C = " + toFahrenheit + " F");
                }
                else
                {
                    int toCelsius = (int) (Math.Round(5.0 / 9.0 * (i - 32)));
                    Console.WriteLine(i + " F = " + toCelsius + " C");
                }
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("");
        }
    }
}
