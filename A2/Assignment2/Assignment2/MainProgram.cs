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
    class MainProgram
    {
        /// <summary>
        /// The program starts here by creating an object of the class Menu and calling it's start method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Start();
        }
    }
}
