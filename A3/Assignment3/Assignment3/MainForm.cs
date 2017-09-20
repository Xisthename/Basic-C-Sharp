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
        private FuelCalculator fuelCalc = new FuelCalculator();
        private BodyMassIndex bmiCalc = new BodyMassIndex();

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
                if (fuelCalc.ValidateValues())
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
        /// <returns>Result</returns>
        private bool ReadInputFuel()
        {
            double value;
            bool result = true;

            if (double.TryParse(fuelCurrentKmTextBox.Text, out value))
            {
                fuelCalc.SetCurrentReading(value);
            }
            else
            {
                MessageBox.Show("Current odmeter must be digits only!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            if (double.TryParse(fuelPreviousKmTextBox.Text, out value))
            {
                fuelCalc.SetPreviousReading(value);
            }
            else
            {
                MessageBox.Show("Previous odmeter must be digits only!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            if (double.TryParse(fuelCurrentLiterTextBox.Text, out value))
            {
                fuelCalc.SetFuelAmount(value);
            }
            else
            {
                MessageBox.Show("The amount of fuel must be digits only!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            if (double.TryParse(fuelPriceTextBox.Text, out value))
            {
                fuelCalc.SetUnitPrice(value);
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
            fuelKmPerLitLabel.Text = fuelCalc.CalcConsumptionKmPerLit().ToString();
            fuelLitPerKmLabel.Text = fuelCalc.CalcConsumptionLitPerKm().ToString();
            fuelLitPerMetricMileLabel.Text = fuelCalc.CalcConsumptionLitPerMetricMile().ToString();
            fuelLitPerSweMilLabel.Text = fuelCalc.CalcConsumptionPerSwedishMil().ToString();
            FuelCostLabel.Text = fuelCalc.CalcCostPerKm().ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bmiCalculateButton_Click(object sender, EventArgs e)
        {
            ReadName();
            bmiCalc.SetUnit(bmiMetricRadioButton.Checked);
            UpdateBMIGUI();
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
                bmiCalc.SetName("No Name");
            }
            else
            {
                bmiCalc.SetName(bmiNameTextBox.Text);
            }
        }

        private void UpdateBMIGUI()
        {
            bmiNameLabel.Text = "Results for " + bmiCalc.GetName();
        }
    }
}
