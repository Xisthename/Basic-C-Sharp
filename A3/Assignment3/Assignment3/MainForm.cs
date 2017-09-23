using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    /// <summary>
    /// Daniel Petersén
    /// 2017-09-14
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Creating and declaring some objects 
        /// </summary>
        private FuelCalculator fuel = new FuelCalculator();
        private BodyMassIndex bmi = new BodyMassIndex();
        private BasalMetabolicRate bmr = new BasalMetabolicRate();

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the user presses the button to calculate there fuel
        /// We call on the method ReadInputFuel that takes in the input and checks if it can be converted to doubles
        /// If all was converted we ask the object to validate the values of the input
        /// If the values are okay the calculation begins and are shown to the user through the method UpdateFuelGUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fuelCalculateButton_Click(object sender, EventArgs e)
        {
            if (ReadInputFuel())
            {
                if (fuel.ValidateValues())
                {
                    UpdateFuelGUI();
                }
            }
        }

        /// <summary>
        /// Tries to convert fuel inputs to doubles
        /// When an input can be converted we accses the fuel object and set in that value in corresponding set method
        /// When an input can't be converted we tell the user that the input must be in digits
        /// Returns true if all input is converted to doubles otherwise false
        /// </summary>
        /// <returns>The result</returns>
        private bool ReadInputFuel()
        {
            double value;
            bool result = true;

            if (double.TryParse(fuelCurrentKmTextBox.Text, out value))
            {
                fuel.SetCurrentReading(value);
            }
            else
            {
                MessageBox.Show("Current odmeter must be digits only!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            if (double.TryParse(fuelPreviousKmTextBox.Text, out value))
            {
                fuel.SetPreviousReading(value);
            }
            else
            {
                MessageBox.Show("Previous odmeter must be digits only!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            if (double.TryParse(fuelCurrentLiterTextBox.Text, out value))
            {
                fuel.SetFuelAmount(value);
            }
            else
            {
                MessageBox.Show("The amount of fuel must be digits only!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            if (double.TryParse(fuelPriceTextBox.Text, out value))
            {
                fuel.SetUnitPrice(value);
            }
            else
            {
                MessageBox.Show("The price must be digits only!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            return result;
        }

        /// <summary>
        /// Updates the text of the fuel labels to the result calcualted and returned from the fuel object
        /// </summary>
        private void UpdateFuelGUI()
        {
            fuelKmPerLitLabel.Text = fuel.CalcConsumptionKmPerLit().ToString();
            fuelLitPerKmLabel.Text = fuel.CalcConsumptionLitPerKm().ToString();
            fuelLitPerMetricMileLabel.Text = fuel.CalcConsumptionLitPerMetricMile().ToString();
            fuelLitPerSweMilLabel.Text = fuel.CalcConsumptionLitPerSwedishMil().ToString();
            FuelCostLabel.Text = fuel.CalcCostPerKm().ToString();
        }

        /// <summary>
        /// Changes the info depending on which one that are selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bmiMetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (bmiMetricRadioButton.Checked)
            {
                bmiHeightLabel.Text = "Height (cm)";
                bmiWeightLabel.Text = "Weight (kg)";
            }
            else
            {
                bmiHeightLabel.Text = "Height (in)";
                bmiWeightLabel.Text = "Weight (lb)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bmiCalculateButton_Click(object sender, EventArgs e)
        {
            if (ReadInputBMI())
            {
                if (bmi.ValidateValues())
                {
                    UpdateBMIGUI();
                }
            }
        }

        /// <summary>
        /// /// Tries to convert BMI inputs to doubles
        /// When an input can be converted we accses the bmi object and set in that value in corresponding set method
        /// When an input can't be converted we tell the user that the input must be in digits
        /// Returns true if all input is converted to doubles otherwise false
        /// </summary>
        /// <returns>The result</returns>
        private bool ReadInputBMI()
        {
            float value;
            bool result = true;

            if (float.TryParse(bmiHeightTextBox.Text, out value))
            {
                bmi.SetHeight(value);
            }
            else
            {
                MessageBox.Show("The height must be digits only!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            if (float.TryParse(bmiWeightTextBox.Text, out value))
            {
                bmi.SetWeight(value);
            }
            else
            {
                MessageBox.Show("The weight must be digits only!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            ReadName();
            bmi.SetUnit(bmiMetricRadioButton.Checked);
            return result;
        }

        /// <summary>
        ///  Takes in the name and deicides if the name is blank or not 
        ///  calls on the method setname inside of the bmi object
        ///  If not blank set what was written
        ///  If blank set the value "No Name"
        /// </summary>
        private void ReadName()
        {
            if (bmiNameTextBox.Text.Trim().Equals(""))
            {
                bmi.SetName("No Name");
            }
            else
            {
                bmi.SetName(bmiNameTextBox.Text);
            }
        }

        /// <summary>
        /// Updates the text of the BMI labels to the result calcualted and returned from the bmi object
        /// </summary>
        private void UpdateBMIGUI()
        {
            bmiBoxResults.Text = "Results for " + bmi.GetName();
            bmiResultLabel.Text = bmi.CalcBMI().ToString("0.00");
            bmiCategoryLabel.Text = bmi.CalcCategory();
        }
    }
}
