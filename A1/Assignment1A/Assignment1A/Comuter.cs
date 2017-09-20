using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1A
{
    /// <summary>
    /// En klass som kan hålla reda på vad en dator kostar, vilket märke den har ch vilken färg
    /// </summary>
    class Comuter
    {
        // Instansvariabler för att hålla nödvändig information
        private int cost;
        private String brand;
        private String color;

        /// <summary>
        /// Simpel set metod som sparar paramenterns värde
        /// </summary>
        /// <param name="cost"></param>
        public void SetCost(int cost)
        {
            this.cost = cost;
        }

        /// <summary>
        /// Simpel set metod som sparar paramenterns värde
        /// </summary>
        /// <param name="brand"></param>
        public void SetBrand(String brand)
        {
            this.brand = brand;
        }

        /// <summary>
        /// Simpel set metod som sparar paramenterns värde
        /// </summary>
        /// <param name="color"></param>
        public void SetColor(String color)
        {
            this.color = color;
        }

        /// <summary>
        /// Simpel get metod som retunerar cost
        /// </summary>
        /// <returns>Värdet i cost</returns>
        public int GetCost()
        {
            return cost;
        }

        /// <summary>
        /// Simpel get metod som retunerar brand
        /// </summary>
        /// <returns>Värdet i brand</returns>
        public String GetBrand()
        {
            return brand;
        }

        /// <summary>
        /// Simpel get metod som retunerar color
        /// </summary>
        /// <returns>Värdet i color</returns>
        public String GetColor()
        {
            return color;
        }

        /// <summary>
        /// Skriver ut informationen av datorn
        /// </summary>
        public void DisplayInfoText()
        {
            Console.WriteLine("");
            Console.WriteLine("+++++++++++++++++++++++++++++++");
            Console.WriteLine("COMPUTER SUMMARY");
            Console.WriteLine("Cost: " + cost);
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("+++++++++++++++++++++++++++++++");
            Console.WriteLine("");
        }
    }
}
