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
    /// 2017-09-24
    /// </summary>
    class BasalMetabolicRate
    {
        /// <summary>
        /// Delecering necessary instance variables
        /// </summary>
        private String name;
        private double height;
        private double weight;
        private int age;
        private bool female;
        private int activityIndex;
        private String[] activityArrayInfo =
        {
            "Sedentary(little or no exercise)",
            "Lightly active (1-3 times)",
            "Moderately active (3-5 times)",
            "Very active (6-7 times)",
            "Extra active, hard exercises or job"
        };
        private double[] activityLevelFactors =
        {
            1.2,
            1.375,
            1.550,
            1.725,
            1.9
        };

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
        /// Simple set method that takes in a value and saves that value into a instance variable
        /// </summary>
        /// <param name="age"></param>
        public void SetAge(int age)
        {
            this.age = age;
        }

        /// <summary>
        /// Simple set method that takes in a value and saves that value into a instance variable
        /// </summary>
        /// <param name="female"></param>
        public void SetGender(bool female)
        {
            this.female = female;
        }

        /// <summary>
        /// Simple set method that takes in a value and saves that value into a instance variable
        /// </summary>
        /// <param name="activityIndex"></param>
        public void SetActivityIndex(int activityIndex)
        {
            this.activityIndex = activityIndex;
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

        /// <summary>
        /// Calculates the BMR value and returns it
        /// </summary>
        /// <returns>The BMR value</returns>
        public double CalcBMRValue()
        {
            double bmrValue = (10 * weight) + (6.25 * height) - (5 * age);

            if (female)
            {
                bmrValue -= 161;
            }
            else
            {
                bmrValue += 5;
            }
            return bmrValue;
        }

        /// <summary>
        /// Calculates the amount of calories needed to maintain the current wright and returns it
        /// </summary>
        /// <returns>The amount of calories</returns>
        public double CalcMaintainWeightCalories()
        {
            return CalcBMRValue() * activityLevelFactors[activityIndex];
        }

        /// <summary>
        /// Calculates the amount of calories needed to add the desired weight
        /// </summary>
        /// <param name="valueInGram"></param>
        /// <returns>The amount of calories</returns>
        public double LoseOrGainWeight(double valueInGram)
        {
            return CalcMaintainWeightCalories() + valueInGram;
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

        /// <summary>
        /// Returns a string array with the info of activity level
        /// </summary>
        /// <returns>Activity levels</returns>
        public String[] GetActivityArrayInfo()
        {
            return activityArrayInfo;
        }
    }
}
