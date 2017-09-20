using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1A
{
    class ObjectOwnerMain
    {
        /// <summary>
        /// Här börjar programet med att skapa ett objekt av klassen Pet
        /// Sen läser vi in nödvändig information och sparar det i objektet pet
        /// Därefter är det bara en summering av inforamtionen som skrivs ut
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            new ObjectOwnerMain();
        }

        /// <summary>
        /// Konstuktor som startar testningen av de två objekten
        /// </summary>
        public ObjectOwnerMain()
        {
            TestPet();
            TestComputer();
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }

        /// <summary>
        /// Test körning av objektet pet
        /// </summary>
        public void TestPet()
        {
            Pet pet = new Pet();
            Console.WriteLine("Welcome! Please fill in your pets information below:");
            Console.WriteLine("What's the name of your pet?");
            pet.SetName(Console.ReadLine());
            Console.WriteLine("What's the age of " + pet.GetName() + "?");
            pet.SetAge(int.Parse(Console.ReadLine()));
            Console.WriteLine("What's the gender of your pet (M/F)?");
            pet.SetGender(Console.ReadLine());
            pet.DisplayInfoText();
            Console.WriteLine("");
        }


        /// <summary>
        /// Test körning av objektet computer
        /// </summary>
        private void TestComputer()
        {
            Comuter computer = new Comuter();
            Console.WriteLine("Welcome! Please fill in your computers information below:");
            Console.WriteLine("What did your computer cost?");
            computer.SetCost(int.Parse(Console.ReadLine()));
            Console.WriteLine("What's the brand of the computer?");
            computer.SetBrand(Console.ReadLine());
            Console.WriteLine("What's the color of the computer?");
            computer.SetColor(Console.ReadLine());
            computer.DisplayInfoText();
            Console.WriteLine("");
        }
    }
}
