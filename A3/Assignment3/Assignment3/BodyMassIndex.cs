using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    /// <summary>
    /// Daniel Petersén
    /// 2017-09-18
    /// </summary>
    class BodyMassIndex
    {
        private String name;
        private bool metricUnits;
        private double height;
        private double weight;

        /// <summary>
        /// Simple set method that takes in a value and saves that value into a instance variable
        /// </summary>
        /// <param name="name"></param>
        public void SetName(String name)
        {
            this.name = name;
        }

        /// <summary>
        /// Simple set method that takes in a value and saves that value into a instance variable
        /// </summary>
        /// <param name="metricUnits"></param>
        public void SetUnit(bool metricUnits)
        {
            this.metricUnits = metricUnits;
        }

        /// <summary>
        /// Simple set method that takes in a value and saves that value into a instance variable
        /// </summary>
        /// <param name="height"></param>
        public void SetHeight(double height)
        {
            this.height = height;
        }

        /// <summary>
        /// Simple set method that takes in a value and saves that value into a instance variable
        /// </summary>
        /// <param name="weight"></param>
        public void SetWeight(double weight)
        {
            this.weight = weight;
        }

        /// <summary>
        /// Validates the input values with corresponding conditions 
        /// If a condition is false we let the user know what was wrong and the method returns false
        /// If ALL conditions are true we return true
        /// </summary>
        /// <returns>result</returns>
        public bool ValidateValues()
        {
            bool result = true;

            if (!(height > 0))
            {
                MessageBox.Show("The height must be greater than zero!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            if (!(weight > 0))
            {
                MessageBox.Show("The weight must be greater than zero!!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            return result;
        }

        //BMI = weight in kg / height2(in m2) (Metric Units)
        //BMI = 703.0 *·weight(in lb) / height2(in inch2) (U.S.Units)

        /// <summary>
        /// Calcualtes you BMI in Metric units or U.S units depending on the boolean metricUnits
        /// Rounds of the value to 1 decimal
        /// </summary>
        /// <returns>The calculated BMI value</returns>
        public double CalcBMI()
        {
            if (metricUnits)
            {
                double heightCmToMeter = (height / 100);
                return Math.Round(weight / (heightCmToMeter * heightCmToMeter), 1);
            }
            else
            {
                return Math.Round((703.0 * weight) / (height * height), 1);
            }
        }

        /// <summary>
        /// Tries to find a category acorrding to the BMI value of a person
        /// </summary>
        /// <returns>A category</returns>
        public String CalcCategory()
        {
            double bmiValue = CalcBMI();
            String category = "Error no category found";

            if (bmiValue < 18.5)
            {
                category = "Underweight";
            }
            else if (bmiValue >= 18.5 && bmiValue <= 24.9)
            {
                category = "Normal weight";
            }
            else if (bmiValue >= 25.0 && bmiValue <= 29.9)
            {
                category = "Overweight (Pre-obesity)";
            }
            else if (bmiValue >= 30.0 && bmiValue <= 34.9)
            {
                category = "Obesity class I";
            }
            else if (bmiValue >= 35.0 && bmiValue <= 39.9)
            {
                category = "Obesity class II";
            }
            else if (bmiValue > 40)
            {
                category = "Obesity class III";
            }
            return category;
        }

        /// <summary>
        /// Simple get method that returns the value of an instance variable
        /// </summary>
        /// <returns>name</returns>
        public String GetName()
        {
            return name;
        }

        /// <summary>
        /// Simple get method that returns the value of an instance variable
        /// </summary>
        /// <returns>height</returns>
        public double GetHeight()
        {
            return height;
        }

        /// <summary>
        /// Simple get method that returns the value of an instance variable
        /// </summary>
        /// <returns>weight</returns>
        public double GetWeight()
        {
            return weight;
        }
    }
}
