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
    class WorkSchedule
    {
        /// <summary>
        /// A small Menu that gives the option of showing work during weekends or during the nights
        /// And of course the option of going back to the Main Menu by entering zero
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
                        ShowWeekends();
                        break;
                    case 2:
                        ShowNights();
                        break;
                }
            }
        }

        /// <summary>
        /// Writes out some info
        /// </summary>
        private void WriteInfoText()
        {
            Console.WriteLine("                         WORK SCHEDULE");
            Console.WriteLine("Select from the menu which type of schedule you would like to see!");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine();
        }

        /// <summary>
        /// Writes out valuable info how to select from the Menu
        /// </summary>
        private void WriteMenuText()
        {
            Console.WriteLine("1 Show a list of the weekends to work");
            Console.WriteLine("2 Show a list of the nigths to work");
            Console.WriteLine("0 Return to Main Menu");
            Console.WriteLine();
            Console.WriteLine("Your choice: ");
        }

        /// <summary>
        /// When called upon this calls upon 'ShowSchedule' and tells that method where to start and what intervall
        /// it should use in it's loops
        /// </summary>
        private void ShowWeekends()
        {
            ShowSchedule(1, 3);
        }

        /// <summary>
        /// When called upon this calls upon 'ShowSchedule' and tells that method where to start and what intervall
        /// it should use in it's loops
        /// </summary>
        private void ShowNights()
        {
            ShowSchedule(6, 5);
        }

        /// <summary>
        /// Takes in two parameters that tells the loop at which index to start and
        /// how much it should jump every intervall
        /// The if-sats just makes the table stright down in each column (numbers abow 10 takes one more space than under 10) 34vs7
        /// </summary>
        /// <param name="start">Starting index of the loop</param>
        /// <param name="jump">How much the index will be increamented by</param>
        private void ShowSchedule(int start, int jump)
        {
            for (int x = start; x <= 52;)
            {
                for (int y = 0; y < 3 && x <= 52; y++, x += jump)
                {
                    if (x < 10)
                    {
                        Console.Write("         Week " + x + " ");
                    }
                    else
                    {
                        Console.Write("         Week " + x);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine();
        }
    }
}
