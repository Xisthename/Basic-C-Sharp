﻿using System;
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
    class FuelCalculator
    {
        /// <summary>
        /// Delecering necessary instance variables
        /// </summary>
        private double currentReading;
        private double previousReading;
        private double fuelAmount;
        private double unitPrice;

        /// <summary>
        /// Simple set method that takes in a value and saves that value into a instance variable
        /// </summary>
        /// <param name="currentReading"></param>
        public void SetCurrentReading(double currentReading)
        {
            this.currentReading = currentReading;
        }

        /// <summary>
        /// Simple set method that takes in a value and saves that value into a instance variable
        /// </summary>
        /// <param name="previousReading"></param>
        public void SetPreviousReading(double previousReading)
        {
            this.previousReading = previousReading;
        }

        /// <summary>
        /// Simple set method that takes in a value and saves that value into a instance variable
        /// </summary>
        /// <param name="fuelAmount"></param>
        public void SetFuelAmount(double fuelAmount)
        {
            this.fuelAmount = fuelAmount;
        }

        /// <summary>
        /// Simple set method that takes in a value and saves that value into a instance variable
        /// </summary>
        /// <param name="unitPrice"></param>
        public void SetUnitPrice(double unitPrice)
        {
            this.unitPrice = unitPrice;
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

            if (!(previousReading >= 0))
            {
                MessageBox.Show("Previous odometer cannot be negative!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            if (!(currentReading > previousReading))
            {
                MessageBox.Show("Current odometer must be greater than previous odometer!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            if (!(fuelAmount >= 0))
            {
                MessageBox.Show("The amount of fuel cannot be negative!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            if (!(unitPrice >= 0))
            {
                MessageBox.Show("The price cannot be negative!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            return result;
        }

        /// <summary>
        /// Calculates the fuel consumption of km per liter
        /// </summary>
        /// <returns>The value of the consumption</returns>
        public double CalcConsumptionKmPerLit()
        {
            return (currentReading - previousReading) / fuelAmount;
        }

        /// <summary>
        /// Calculates the fuel consumption of liter per km
        /// </summary>
        /// <returns>The value of the consumption</returns>
        public double CalcConsumptionLitPerKm()
        {
            return fuelAmount / (currentReading - previousReading);
        }

        /// <summary>
        /// Calculates the fuel consumption of liter per metric mile
        /// </summary>
        /// <returns>The value of the consumption</returns>
        public double CalcConsumptionLitPerMetricMile()
        {
            const double kmToMileFactor = 0.621371192;
            return CalcConsumptionLitPerKm() / kmToMileFactor;
        }

        /// <summary>
        /// Calculates the fuel consumption of liter per swedish mil
        /// </summary>
        /// <returns>The value of the consumption</returns>
        public double CalcConsumptionLitPerSwedishMil()
        {
            return CalcConsumptionLitPerKm() * 10;
        }

        /// <summary>
        /// Calculates the cost per km
        /// </summary>
        /// <returns>The cost value</returns>
        public double CalcCostPerKm()
        {
            return CalcConsumptionLitPerKm() * unitPrice;
        }

        /// <summary>
        /// Simple get method that returns the value of an instance variable
        /// </summary>
        /// <returns>currentReading</returns>
        public double GetCurrentReading()
        {
            return currentReading;
        }

        /// <summary>
        /// Simple get method that returns the value of an instance variable
        /// </summary>
        /// <returns>previousReading</returns>
        public double GetPreviousReading()
        {
            return previousReading;
        }

        /// <summary>
        /// Simple get method that returns the value of an instance variable
        /// </summary>
        /// <returns>fuelAmount</returns>
        public double GetFuelAmount()
        {
            return fuelAmount;
        }

        /// <summary>
        /// Simple get method that returns the value of an instance variable
        /// </summary>
        /// <returns>unitPrice</returns>
        public double GetUnitPrice()
        {
            return unitPrice;
        }
    }
}
