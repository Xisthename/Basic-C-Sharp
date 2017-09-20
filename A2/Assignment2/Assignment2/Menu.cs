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
    class Menu
    {
        /// <summary>
        /// This is where the main Menu and it's options are chosen by a number
        /// The user exits the loop and therfore the program by a 0
        /// </summary>
        public void Start()
        {
            Console.Title = "Selection and iteration algorithms";
            int choice = -1;

            while (choice != 0)
            {
                WriteInfoText();
                choice = Input.ReadIntegerConsole();

                switch (choice)
                {
                    case 1:
                        AddWholeNumbers sumInt = new AddWholeNumbers();
                        sumInt.Start();
                        break;
                    case 2:
                        AddFloatingNumbers sumDouble = new AddFloatingNumbers();
                        sumDouble.Start();
                        break;
                    case 3:
                        CurrencyConverter sumConvert = new CurrencyConverter();
                        sumConvert.Start();
                        break;
                    case 4:
                        WorkSchedule workSchedule = new WorkSchedule();
                        workSchedule.Start();
                        break;
                    case 5:
                        TempatureTable tempatureTable = new TempatureTable();
                        tempatureTable.Start();
                        break;
                }
            }
        }

        /// <summary>
        /// Writes out some info about the Menu and how the user can select things from it
        /// </summary>
        private void WriteInfoText()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("                 MAIN MENU");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("     Sum Whole Nnumbers with For             : 1");
            Console.WriteLine("     Sum Floting Point Nnumbers with While   : 2");
            Console.WriteLine("     Currency Converter with Do While        : 3");
            Console.WriteLine("     Work Schedule                           : 4");
            Console.WriteLine("     Tempeture Table                         : 5");
            Console.WriteLine("     Exit the program                        : 0");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Your choice:");
        }
    }
}
