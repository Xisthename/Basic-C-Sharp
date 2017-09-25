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

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitGUI();
        }

        /// <summary>
        /// Initializes the combobox's GUI
        /// </summary>
        private void InitGUI()
        {
            bmrActivityComboBox.Items.AddRange(bmr.GetActivityArrayInfo());
            bmrActivityComboBox.SelectedIndex = 0;
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
            if (ReadFuelInputs())
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
        private bool ReadFuelInputs()
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
                bmiHeightInfo.Text = "Height (cm)";
                bmiWeightInfo.Text = "Weight (kg)";
            }
            else
            {
                bmiHeightInfo.Text = "Height (in)";
                bmiWeightInfo.Text = "Weight (lb)";
            }
        }

        /// <summary>
        /// First we read in all inputs and tries to convert some to doubles
        /// If they can't be converted we stop and tell the user what's wrong
        /// We send in the boolean value of the metric unit (checked, true or not checked, false)
        /// If the values are okay the calculation begins and are shown to the user through the method UpdateBMIGUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bmiCalculateButton_Click(object sender, EventArgs e)
        {
            if (ReadBMIInputs())
            {
                if (bmi.ValidateValues())
                {
                    ReadBMIName();
                    bmi.SetUnit(bmiMetricRadioButton.Checked);
                    UpdateBMIGUI();
                }
            }
        }

        /// <summary>
        /// Tries to convert BMI inputs to doubles
        /// When an input can be converted we accses the bmi object and set in that value in corresponding set method
        /// When an input can't be converted we tell the user that the input must be in digits
        /// Returns true if all input is converted to doubles otherwise false
        /// </summary>
        /// <returns>The result</returns>
        private bool ReadBMIInputs()
        {
            double value;
            bool result = true;

            if (double.TryParse(bmiHeightTextBox.Text, out value))
            {
                bmi.SetHeight(value);
            }
            else
            {
                MessageBox.Show("The height must be digits only!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            if (double.TryParse(bmiWeightTextBox.Text, out value))
            {
                bmi.SetWeight(value);
            }
            else
            {
                MessageBox.Show("The weight must be digits only!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            return result;
        }

        /// <summary>
        ///  Takes in the name and deicides if the name is blank or not 
        ///  calls on the method setname inside of the bmi object
        ///  If not blank set what was written
        ///  If blank set the value "No Name"
        /// </summary>
        private void ReadBMIName()
        {
            if (!(String.IsNullOrEmpty(bmiNameTextBox.Text.Trim())))
            {
                bmi.SetName(bmiNameTextBox.Text);
            }
            else
            {
                bmi.SetName("No Name");
            }
        }

        /// <summary>
        /// Updates the text of the BMI labels to the result calcualted and returned from the bmi object
        /// </summary>
        private void UpdateBMIGUI()
        {
            bmiBoxResults.Text = "Results for " + bmi.GetName();
            bmiResultLabel.Text = bmi.CalcBMI().ToString();
            bmiCategoryLabel.Text = bmi.CalcCategory();
        }

        private void bmrCalculateButton_Click(object sender, EventArgs e)
        {
            if (ReadBMRInputs())
            {
                if (bmr.ValidateValues())
                {
                    ReadBMRName();
                    ReadBMRGender();
                    ReadBMRActivityLevel();
                    UpdateBMRGUI();
                }
            }
        }

        /// <summary>
        /// Tries to convert BMR inputs to doubles and the age to a int
        /// When an input can be converted we accses the bmr object and set in that value in corresponding set method
        /// When an input can't be converted we tell the user that the input must be in digits
        /// Returns true if all input is converted to doubles otherwise false
        /// </summary>
        /// <returns>The result</returns>
        private bool ReadBMRInputs()
        {
            double value;
            bool result = true;

            if (double.TryParse(bmrHeightTextBox.Text, out value))
            {
                bmr.SetHeight(value);
            }
            else
            {
                MessageBox.Show("The height must be digits only!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            if (double.TryParse(bmrWeightTextBox.Text, out value))
            {
                bmr.SetWeight(value);
            }
            else
            {
                MessageBox.Show("The weight must be digits only!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            try
            {
                bmr.SetAge(int.Parse(bmrAgeTextBox.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("The age must be in whole years!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            return result;
        }

        /// <summary>
        ///  Takes in the name and deicides if the name is blank or not 
        ///  calls on the method setname inside of the bmi object
        ///  If not blank set what was written
        ///  If blank set the value "No Name"
        /// </summary>
        private void ReadBMRName()
        {
            if (!(String.IsNullOrEmpty(bmrNameTextBox.Text.Trim())))
            {
                bmr.SetName(bmrNameTextBox.Text);
            }
            else
            {
                bmr.SetName("No Name");
            }
        }

        /// <summary>
        /// Sets the gender to true or false
        /// True if a female and false if a male
        /// </summary>
        private void ReadBMRGender()
        {
            bmr.SetGender(bmrFemaleRadioButton.Checked);
        }

        /// <summary>
        /// Sets the activity index to what the selected index of the activity combobox
        /// </summary>
        private void ReadBMRActivityLevel()
        {
           bmr.SetActivityIndex(bmrActivityComboBox.SelectedIndex);
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateBMRGUI()
        {
            bmrListView.Clear();
            bmrListView.Items.Add("BMR results for " + bmr.GetName());
            bmrListView.Items.Add("");
            bmrListView.Items.Add("Your BMR (calories/day) " + bmr.CalcBMRValue());
            bmrListView.Items.Add("Calories to maintain weight " + bmr.CalcMaintainWeightCalories());
            bmrListView.Items.Add("Calories to lose 0.5 kg per week " + bmr.LoseOrGainWeight(-500));
            bmrListView.Items.Add("Calories to lose 1 kg per week " + bmr.LoseOrGainWeight(-1000));
            bmrListView.Items.Add("Calories to gain 0.5 kg per week " + bmr.LoseOrGainWeight(500));
            bmrListView.Items.Add("Calories to gain 1 kg per week " + bmr.LoseOrGainWeight(1000));
            bmrListView.Items.Add("");
            bmrListView.Items.Add("Losing more than 1000 calories per day is to be avoided!");
        }

        /// <summary>
        /// When the selection changes we try to find the new selected item index
        /// We also update the GUI to let the user know what we found out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bmrListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = GetSelectedIndex();

            if (index != -1)
            {
                bmrSelectedItemLabel.Text = "Selected item: " + GetSelectedIndex();
            }
            else
            {
                bmrSelectedItemLabel.Text = "Selected item: None";
            }
        }

        /// <summary>
        /// Finds the selected index and returns it
        /// If no item was selected it returns -1
        /// </summary>
        /// <returns>The index</returns>
        private int GetSelectedIndex()
        {
            for(int i = 0; i < bmrListView.Items.Count; i++)
            {
                if (bmrListView.Items[i].Selected)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Unselects selected items from the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bmrUnselectButton_Click(object sender, EventArgs e)
        {
            UnselectSelectedItems();
        }

        /// <summary>
        /// Unselects selected items from the list
        /// </summary>
        private void UnselectSelectedItems()
        {
            bmrListView.SelectedItems.Clear();
        }
    }
}
