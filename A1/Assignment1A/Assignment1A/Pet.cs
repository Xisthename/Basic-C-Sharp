using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1A
{
    /// <summary>
    /// En liten klass som kan hålla reda på information om ett husdjur
    /// </summary>
    class Pet
    {
        // Instansvariabler för att hålla nödvändig information
        private String name;
        private int age;
        private bool isFemale;

        /// <summary>
        /// Simpel set metod som sparar paramenterns värde
        /// </summary>
        /// <param name="name"></param>
        public void SetName(String name)
        {
            this.name = name;
        }

        /// <summary>
        /// Simpel set metod som sparar paramenterns värde
        /// </summary>
        /// <param name="age"></param>
        public void SetAge(int age)
        {
            this.age = age;
        }

        /// <summary>
        /// Simpel set metod som sparar paramenterns värde
        /// </summary>
        /// <param name="gender"></param>
        public void SetGender(String gender)
        {
            if (gender.ToUpper().Equals("F"))
            {
                isFemale = true;
            }
            else
            {
                isFemale = false;
            }
        }

        /// <summary>
        /// Simpel get metod som retunerar name
        /// </summary>
        /// <returns>Värdet i name</returns>
        public String GetName()
        {
            return name;
        }

        /// <summary>
        /// Simpel get metod som retunerar age
        /// </summary>
        /// <returns>Värdet i age</returns>
        public int GetAge()
        {
            return age;
        }

        /// <summary>
        /// Simpel get metod som retunerar isFemale
        /// </summary>
        /// <returns>Värdet i isFemale</returns>
        public bool GenderIsFemale()
        {
            return isFemale;
        }

        /// <summary>
        /// Skriver ut informationen av husdjuret
        /// </summary>
        public void DisplayInfoText()
        {
            Console.WriteLine("");
            Console.WriteLine("+++++++++++++++++++++++++++++++");
            Console.WriteLine("PET SUMMARY");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);

            if (GenderIsFemale())
            {
                Console.WriteLine(name + " is a good girl!");
            }
            else
            {
                Console.WriteLine(name + " is a good boy!");
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++");
            Console.WriteLine("");
        }
    }
}
