namespace Assignment3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fuelBox = new System.Windows.Forms.GroupBox();
            this.fuelBoxResults = new System.Windows.Forms.GroupBox();
            this.fuelLitPerSweMilInfo = new System.Windows.Forms.Label();
            this.fuelLitPerMetricMileInfo = new System.Windows.Forms.Label();
            this.fuelCostInfo = new System.Windows.Forms.Label();
            this.FuelCostLabel = new System.Windows.Forms.Label();
            this.fuelLitPerSweMilLabel = new System.Windows.Forms.Label();
            this.fuelLitPerMetricMileLabel = new System.Windows.Forms.Label();
            this.fuelLitPerKmLabel = new System.Windows.Forms.Label();
            this.fuelKmPerLitLabel = new System.Windows.Forms.Label();
            this.fuelLitPerKmInfo = new System.Windows.Forms.Label();
            this.fuelKmPerLitInfo = new System.Windows.Forms.Label();
            this.fuelCalculateButton = new System.Windows.Forms.Button();
            this.fuelPriceTextBox = new System.Windows.Forms.TextBox();
            this.fuelPriceInfo = new System.Windows.Forms.Label();
            this.fuelCurrentLiterTextBox = new System.Windows.Forms.TextBox();
            this.fuelCurrentLiterInfo = new System.Windows.Forms.Label();
            this.fuelPreviousKmInfo = new System.Windows.Forms.Label();
            this.fuelPreviousKmTextBox = new System.Windows.Forms.TextBox();
            this.fuelCurrentKmTextBox = new System.Windows.Forms.TextBox();
            this.fuelCurrentKmInfo = new System.Windows.Forms.Label();
            this.bmiBox = new System.Windows.Forms.GroupBox();
            this.bmiUsRadioButton = new System.Windows.Forms.RadioButton();
            this.bmiMetricRadioButton = new System.Windows.Forms.RadioButton();
            this.bmiBoxResults = new System.Windows.Forms.GroupBox();
            this.bmiNormalInfo = new System.Windows.Forms.Label();
            this.bmiCategoryLabel = new System.Windows.Forms.Label();
            this.bmiResultLabel = new System.Windows.Forms.Label();
            this.bmiCategoryInfo = new System.Windows.Forms.Label();
            this.bmiResultInfo = new System.Windows.Forms.Label();
            this.bmiCalculateButton = new System.Windows.Forms.Button();
            this.bmiWeightTextBox = new System.Windows.Forms.TextBox();
            this.bmiWeightLabel = new System.Windows.Forms.Label();
            this.bmiHeightLabel = new System.Windows.Forms.Label();
            this.bmiHeightTextBox = new System.Windows.Forms.TextBox();
            this.bmiNameTextBox = new System.Windows.Forms.TextBox();
            this.bmiNameLabel = new System.Windows.Forms.Label();
            this.fuelBox.SuspendLayout();
            this.fuelBoxResults.SuspendLayout();
            this.bmiBox.SuspendLayout();
            this.bmiBoxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // fuelBox
            // 
            this.fuelBox.Controls.Add(this.fuelBoxResults);
            this.fuelBox.Controls.Add(this.fuelCalculateButton);
            this.fuelBox.Controls.Add(this.fuelPriceTextBox);
            this.fuelBox.Controls.Add(this.fuelPriceInfo);
            this.fuelBox.Controls.Add(this.fuelCurrentLiterTextBox);
            this.fuelBox.Controls.Add(this.fuelCurrentLiterInfo);
            this.fuelBox.Controls.Add(this.fuelPreviousKmInfo);
            this.fuelBox.Controls.Add(this.fuelPreviousKmTextBox);
            this.fuelBox.Controls.Add(this.fuelCurrentKmTextBox);
            this.fuelBox.Controls.Add(this.fuelCurrentKmInfo);
            this.fuelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fuelBox.Location = new System.Drawing.Point(12, 12);
            this.fuelBox.Name = "fuelBox";
            this.fuelBox.Size = new System.Drawing.Size(500, 415);
            this.fuelBox.TabIndex = 0;
            this.fuelBox.TabStop = false;
            this.fuelBox.Text = "Fuel";
            // 
            // fuelBoxResults
            // 
            this.fuelBoxResults.Controls.Add(this.fuelLitPerSweMilInfo);
            this.fuelBoxResults.Controls.Add(this.fuelLitPerMetricMileInfo);
            this.fuelBoxResults.Controls.Add(this.fuelCostInfo);
            this.fuelBoxResults.Controls.Add(this.FuelCostLabel);
            this.fuelBoxResults.Controls.Add(this.fuelLitPerSweMilLabel);
            this.fuelBoxResults.Controls.Add(this.fuelLitPerMetricMileLabel);
            this.fuelBoxResults.Controls.Add(this.fuelLitPerKmLabel);
            this.fuelBoxResults.Controls.Add(this.fuelKmPerLitLabel);
            this.fuelBoxResults.Controls.Add(this.fuelLitPerKmInfo);
            this.fuelBoxResults.Controls.Add(this.fuelKmPerLitInfo);
            this.fuelBoxResults.Location = new System.Drawing.Point(10, 208);
            this.fuelBoxResults.Name = "fuelBoxResults";
            this.fuelBoxResults.Size = new System.Drawing.Size(480, 200);
            this.fuelBoxResults.TabIndex = 1;
            this.fuelBoxResults.TabStop = false;
            this.fuelBoxResults.Text = "Results";
            // 
            // fuelLitPerSweMilInfo
            // 
            this.fuelLitPerSweMilInfo.AutoSize = true;
            this.fuelLitPerSweMilInfo.Location = new System.Drawing.Point(6, 134);
            this.fuelLitPerSweMilInfo.Name = "fuelLitPerSweMilInfo";
            this.fuelLitPerSweMilInfo.Size = new System.Drawing.Size(242, 20);
            this.fuelLitPerSweMilInfo.TabIndex = 15;
            this.fuelLitPerSweMilInfo.Text = "Fuel consumption (lit/swe mile)";
            // 
            // fuelLitPerMetricMileInfo
            // 
            this.fuelLitPerMetricMileInfo.AutoSize = true;
            this.fuelLitPerMetricMileInfo.Location = new System.Drawing.Point(5, 100);
            this.fuelLitPerMetricMileInfo.Name = "fuelLitPerMetricMileInfo";
            this.fuelLitPerMetricMileInfo.Size = new System.Drawing.Size(259, 20);
            this.fuelLitPerMetricMileInfo.TabIndex = 14;
            this.fuelLitPerMetricMileInfo.Text = "Fuel consumption (lit/metric mile)";
            // 
            // fuelCostInfo
            // 
            this.fuelCostInfo.AutoSize = true;
            this.fuelCostInfo.Location = new System.Drawing.Point(6, 168);
            this.fuelCostInfo.Name = "fuelCostInfo";
            this.fuelCostInfo.Size = new System.Drawing.Size(146, 20);
            this.fuelCostInfo.TabIndex = 9;
            this.fuelCostInfo.Text = "Cost per kilometer";
            // 
            // FuelCostLabel
            // 
            this.FuelCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FuelCostLabel.Location = new System.Drawing.Point(318, 167);
            this.FuelCostLabel.Name = "FuelCostLabel";
            this.FuelCostLabel.Size = new System.Drawing.Size(155, 25);
            this.FuelCostLabel.TabIndex = 13;
            // 
            // fuelLitPerSweMilLabel
            // 
            this.fuelLitPerSweMilLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fuelLitPerSweMilLabel.Location = new System.Drawing.Point(318, 133);
            this.fuelLitPerSweMilLabel.Name = "fuelLitPerSweMilLabel";
            this.fuelLitPerSweMilLabel.Size = new System.Drawing.Size(155, 25);
            this.fuelLitPerSweMilLabel.TabIndex = 12;
            // 
            // fuelLitPerMetricMileLabel
            // 
            this.fuelLitPerMetricMileLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fuelLitPerMetricMileLabel.Location = new System.Drawing.Point(318, 99);
            this.fuelLitPerMetricMileLabel.Name = "fuelLitPerMetricMileLabel";
            this.fuelLitPerMetricMileLabel.Size = new System.Drawing.Size(155, 25);
            this.fuelLitPerMetricMileLabel.TabIndex = 11;
            // 
            // fuelLitPerKmLabel
            // 
            this.fuelLitPerKmLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fuelLitPerKmLabel.Location = new System.Drawing.Point(318, 65);
            this.fuelLitPerKmLabel.Name = "fuelLitPerKmLabel";
            this.fuelLitPerKmLabel.Size = new System.Drawing.Size(155, 25);
            this.fuelLitPerKmLabel.TabIndex = 10;
            // 
            // fuelKmPerLitLabel
            // 
            this.fuelKmPerLitLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fuelKmPerLitLabel.Location = new System.Drawing.Point(318, 28);
            this.fuelKmPerLitLabel.Name = "fuelKmPerLitLabel";
            this.fuelKmPerLitLabel.Size = new System.Drawing.Size(155, 25);
            this.fuelKmPerLitLabel.TabIndex = 9;
            // 
            // fuelLitPerKmInfo
            // 
            this.fuelLitPerKmInfo.AutoSize = true;
            this.fuelLitPerKmInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelLitPerKmInfo.Location = new System.Drawing.Point(5, 66);
            this.fuelLitPerKmInfo.Name = "fuelLitPerKmInfo";
            this.fuelLitPerKmInfo.Size = new System.Drawing.Size(198, 20);
            this.fuelLitPerKmInfo.TabIndex = 4;
            this.fuelLitPerKmInfo.Text = "Fuel consumption (lit/km)";
            // 
            // fuelKmPerLitInfo
            // 
            this.fuelKmPerLitInfo.AutoSize = true;
            this.fuelKmPerLitInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelKmPerLitInfo.Location = new System.Drawing.Point(6, 29);
            this.fuelKmPerLitInfo.Name = "fuelKmPerLitInfo";
            this.fuelKmPerLitInfo.Size = new System.Drawing.Size(198, 20);
            this.fuelKmPerLitInfo.TabIndex = 2;
            this.fuelKmPerLitInfo.Text = "Fuel consumption (km/lit)";
            // 
            // fuelCalculateButton
            // 
            this.fuelCalculateButton.Location = new System.Drawing.Point(110, 163);
            this.fuelCalculateButton.Name = "fuelCalculateButton";
            this.fuelCalculateButton.Size = new System.Drawing.Size(220, 40);
            this.fuelCalculateButton.TabIndex = 8;
            this.fuelCalculateButton.Text = "Calculate";
            this.fuelCalculateButton.UseVisualStyleBackColor = true;
            this.fuelCalculateButton.Click += new System.EventHandler(this.fuelCalculateButton_Click);
            // 
            // fuelPriceTextBox
            // 
            this.fuelPriceTextBox.Location = new System.Drawing.Point(328, 130);
            this.fuelPriceTextBox.Name = "fuelPriceTextBox";
            this.fuelPriceTextBox.Size = new System.Drawing.Size(155, 27);
            this.fuelPriceTextBox.TabIndex = 7;
            // 
            // fuelPriceInfo
            // 
            this.fuelPriceInfo.AutoSize = true;
            this.fuelPriceInfo.Location = new System.Drawing.Point(6, 133);
            this.fuelPriceInfo.Name = "fuelPriceInfo";
            this.fuelPriceInfo.Size = new System.Drawing.Size(110, 20);
            this.fuelPriceInfo.TabIndex = 6;
            this.fuelPriceInfo.Text = "Price per liter";
            // 
            // fuelCurrentLiterTextBox
            // 
            this.fuelCurrentLiterTextBox.Location = new System.Drawing.Point(328, 97);
            this.fuelCurrentLiterTextBox.Name = "fuelCurrentLiterTextBox";
            this.fuelCurrentLiterTextBox.Size = new System.Drawing.Size(155, 27);
            this.fuelCurrentLiterTextBox.TabIndex = 5;
            // 
            // fuelCurrentLiterInfo
            // 
            this.fuelCurrentLiterInfo.AutoSize = true;
            this.fuelCurrentLiterInfo.Location = new System.Drawing.Point(6, 100);
            this.fuelCurrentLiterInfo.Name = "fuelCurrentLiterInfo";
            this.fuelCurrentLiterInfo.Size = new System.Drawing.Size(284, 20);
            this.fuelCurrentLiterInfo.TabIndex = 4;
            this.fuelCurrentLiterInfo.Text = "Current amount of fuel tanked (liters)";
            // 
            // fuelPreviousKmInfo
            // 
            this.fuelPreviousKmInfo.AutoSize = true;
            this.fuelPreviousKmInfo.Location = new System.Drawing.Point(6, 65);
            this.fuelPreviousKmInfo.Name = "fuelPreviousKmInfo";
            this.fuelPreviousKmInfo.Size = new System.Drawing.Size(248, 20);
            this.fuelPreviousKmInfo.TabIndex = 3;
            this.fuelPreviousKmInfo.Text = "Previous odometer reading (km)";
            // 
            // fuelPreviousKmTextBox
            // 
            this.fuelPreviousKmTextBox.Location = new System.Drawing.Point(328, 62);
            this.fuelPreviousKmTextBox.Name = "fuelPreviousKmTextBox";
            this.fuelPreviousKmTextBox.Size = new System.Drawing.Size(155, 27);
            this.fuelPreviousKmTextBox.TabIndex = 2;
            // 
            // fuelCurrentKmTextBox
            // 
            this.fuelCurrentKmTextBox.Location = new System.Drawing.Point(328, 29);
            this.fuelCurrentKmTextBox.Name = "fuelCurrentKmTextBox";
            this.fuelCurrentKmTextBox.Size = new System.Drawing.Size(155, 27);
            this.fuelCurrentKmTextBox.TabIndex = 1;
            // 
            // fuelCurrentKmInfo
            // 
            this.fuelCurrentKmInfo.AutoSize = true;
            this.fuelCurrentKmInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelCurrentKmInfo.Location = new System.Drawing.Point(6, 33);
            this.fuelCurrentKmInfo.Name = "fuelCurrentKmInfo";
            this.fuelCurrentKmInfo.Size = new System.Drawing.Size(239, 20);
            this.fuelCurrentKmInfo.TabIndex = 0;
            this.fuelCurrentKmInfo.Text = "Current odometer reading (km)";
            // 
            // bmiBox
            // 
            this.bmiBox.Controls.Add(this.bmiUsRadioButton);
            this.bmiBox.Controls.Add(this.bmiMetricRadioButton);
            this.bmiBox.Controls.Add(this.bmiBoxResults);
            this.bmiBox.Controls.Add(this.bmiCalculateButton);
            this.bmiBox.Controls.Add(this.bmiWeightTextBox);
            this.bmiBox.Controls.Add(this.bmiWeightLabel);
            this.bmiBox.Controls.Add(this.bmiHeightLabel);
            this.bmiBox.Controls.Add(this.bmiHeightTextBox);
            this.bmiBox.Controls.Add(this.bmiNameTextBox);
            this.bmiBox.Controls.Add(this.bmiNameLabel);
            this.bmiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmiBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bmiBox.Location = new System.Drawing.Point(520, 12);
            this.bmiBox.Name = "bmiBox";
            this.bmiBox.Size = new System.Drawing.Size(425, 415);
            this.bmiBox.TabIndex = 9;
            this.bmiBox.TabStop = false;
            this.bmiBox.Text = "BMI";
            // 
            // bmiUsRadioButton
            // 
            this.bmiUsRadioButton.AutoSize = true;
            this.bmiUsRadioButton.Location = new System.Drawing.Point(225, 98);
            this.bmiUsRadioButton.Name = "bmiUsRadioButton";
            this.bmiUsRadioButton.Size = new System.Drawing.Size(156, 24);
            this.bmiUsRadioButton.TabIndex = 10;
            this.bmiUsRadioButton.Text = "Us Unit (lb, inch)";
            this.bmiUsRadioButton.UseVisualStyleBackColor = true;
            // 
            // bmiMetricRadioButton
            // 
            this.bmiMetricRadioButton.AutoSize = true;
            this.bmiMetricRadioButton.Checked = true;
            this.bmiMetricRadioButton.Location = new System.Drawing.Point(225, 63);
            this.bmiMetricRadioButton.Name = "bmiMetricRadioButton";
            this.bmiMetricRadioButton.Size = new System.Drawing.Size(178, 24);
            this.bmiMetricRadioButton.TabIndex = 9;
            this.bmiMetricRadioButton.TabStop = true;
            this.bmiMetricRadioButton.Text = "Metric Unit (kg, cm)";
            this.bmiMetricRadioButton.UseVisualStyleBackColor = true;
            this.bmiMetricRadioButton.CheckedChanged += new System.EventHandler(this.bmiMetricRadioButton_CheckedChanged);
            // 
            // bmiBoxResults
            // 
            this.bmiBoxResults.Controls.Add(this.bmiNormalInfo);
            this.bmiBoxResults.Controls.Add(this.bmiCategoryLabel);
            this.bmiBoxResults.Controls.Add(this.bmiResultLabel);
            this.bmiBoxResults.Controls.Add(this.bmiCategoryInfo);
            this.bmiBoxResults.Controls.Add(this.bmiResultInfo);
            this.bmiBoxResults.Location = new System.Drawing.Point(10, 208);
            this.bmiBoxResults.Name = "bmiBoxResults";
            this.bmiBoxResults.Size = new System.Drawing.Size(405, 200);
            this.bmiBoxResults.TabIndex = 1;
            this.bmiBoxResults.TabStop = false;
            this.bmiBoxResults.Text = "Results";
            // 
            // bmiNormalInfo
            // 
            this.bmiNormalInfo.AutoSize = true;
            this.bmiNormalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmiNormalInfo.Location = new System.Drawing.Point(7, 138);
            this.bmiNormalInfo.Name = "bmiNormalInfo";
            this.bmiNormalInfo.Size = new System.Drawing.Size(287, 20);
            this.bmiNormalInfo.TabIndex = 11;
            this.bmiNormalInfo.Text = "Normal BMI is between 18.5 and 24.9";
            // 
            // bmiCategoryLabel
            // 
            this.bmiCategoryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bmiCategoryLabel.Location = new System.Drawing.Point(163, 98);
            this.bmiCategoryLabel.Name = "bmiCategoryLabel";
            this.bmiCategoryLabel.Size = new System.Drawing.Size(155, 25);
            this.bmiCategoryLabel.TabIndex = 10;
            // 
            // bmiResultLabel
            // 
            this.bmiResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bmiResultLabel.Location = new System.Drawing.Point(163, 61);
            this.bmiResultLabel.Name = "bmiResultLabel";
            this.bmiResultLabel.Size = new System.Drawing.Size(155, 25);
            this.bmiResultLabel.TabIndex = 9;
            // 
            // bmiCategoryInfo
            // 
            this.bmiCategoryInfo.AutoSize = true;
            this.bmiCategoryInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmiCategoryInfo.Location = new System.Drawing.Point(6, 99);
            this.bmiCategoryInfo.Name = "bmiCategoryInfo";
            this.bmiCategoryInfo.Size = new System.Drawing.Size(133, 20);
            this.bmiCategoryInfo.TabIndex = 4;
            this.bmiCategoryInfo.Text = "Weight Category";
            // 
            // bmiResultInfo
            // 
            this.bmiResultInfo.AutoSize = true;
            this.bmiResultInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmiResultInfo.Location = new System.Drawing.Point(7, 62);
            this.bmiResultInfo.Name = "bmiResultInfo";
            this.bmiResultInfo.Size = new System.Drawing.Size(78, 20);
            this.bmiResultInfo.TabIndex = 2;
            this.bmiResultInfo.Text = "Your BMI";
            // 
            // bmiCalculateButton
            // 
            this.bmiCalculateButton.Location = new System.Drawing.Point(95, 163);
            this.bmiCalculateButton.Name = "bmiCalculateButton";
            this.bmiCalculateButton.Size = new System.Drawing.Size(220, 40);
            this.bmiCalculateButton.TabIndex = 8;
            this.bmiCalculateButton.Text = "Calculate";
            this.bmiCalculateButton.UseVisualStyleBackColor = true;
            this.bmiCalculateButton.Click += new System.EventHandler(this.bmiCalculateButton_Click);
            // 
            // bmiWeightTextBox
            // 
            this.bmiWeightTextBox.Location = new System.Drawing.Point(119, 97);
            this.bmiWeightTextBox.Name = "bmiWeightTextBox";
            this.bmiWeightTextBox.Size = new System.Drawing.Size(100, 27);
            this.bmiWeightTextBox.TabIndex = 5;
            // 
            // bmiWeightLabel
            // 
            this.bmiWeightLabel.AutoSize = true;
            this.bmiWeightLabel.Location = new System.Drawing.Point(6, 100);
            this.bmiWeightLabel.Name = "bmiWeightLabel";
            this.bmiWeightLabel.Size = new System.Drawing.Size(95, 20);
            this.bmiWeightLabel.TabIndex = 4;
            this.bmiWeightLabel.Text = "Weight (kg)";
            // 
            // bmiHeightLabel
            // 
            this.bmiHeightLabel.AutoSize = true;
            this.bmiHeightLabel.Location = new System.Drawing.Point(6, 65);
            this.bmiHeightLabel.Name = "bmiHeightLabel";
            this.bmiHeightLabel.Size = new System.Drawing.Size(98, 20);
            this.bmiHeightLabel.TabIndex = 3;
            this.bmiHeightLabel.Text = "Height (cm)";
            // 
            // bmiHeightTextBox
            // 
            this.bmiHeightTextBox.Location = new System.Drawing.Point(119, 62);
            this.bmiHeightTextBox.Name = "bmiHeightTextBox";
            this.bmiHeightTextBox.Size = new System.Drawing.Size(100, 27);
            this.bmiHeightTextBox.TabIndex = 2;
            // 
            // bmiNameTextBox
            // 
            this.bmiNameTextBox.Location = new System.Drawing.Point(119, 30);
            this.bmiNameTextBox.Name = "bmiNameTextBox";
            this.bmiNameTextBox.Size = new System.Drawing.Size(296, 27);
            this.bmiNameTextBox.TabIndex = 1;
            // 
            // bmiNameLabel
            // 
            this.bmiNameLabel.AutoSize = true;
            this.bmiNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmiNameLabel.Location = new System.Drawing.Point(6, 33);
            this.bmiNameLabel.Name = "bmiNameLabel";
            this.bmiNameLabel.Size = new System.Drawing.Size(53, 20);
            this.bmiNameLabel.TabIndex = 0;
            this.bmiNameLabel.Text = "Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 851);
            this.Controls.Add(this.bmiBox);
            this.Controls.Add(this.fuelBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Universal calculator";
            this.fuelBox.ResumeLayout(false);
            this.fuelBox.PerformLayout();
            this.fuelBoxResults.ResumeLayout(false);
            this.fuelBoxResults.PerformLayout();
            this.bmiBox.ResumeLayout(false);
            this.bmiBox.PerformLayout();
            this.bmiBoxResults.ResumeLayout(false);
            this.bmiBoxResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox fuelBox;
        private System.Windows.Forms.TextBox fuelPriceTextBox;
        private System.Windows.Forms.Label fuelPriceInfo;
        private System.Windows.Forms.TextBox fuelCurrentLiterTextBox;
        private System.Windows.Forms.Label fuelCurrentLiterInfo;
        private System.Windows.Forms.Label fuelPreviousKmInfo;
        private System.Windows.Forms.TextBox fuelPreviousKmTextBox;
        private System.Windows.Forms.TextBox fuelCurrentKmTextBox;
        private System.Windows.Forms.Label fuelCurrentKmInfo;
        private System.Windows.Forms.GroupBox fuelBoxResults;
        private System.Windows.Forms.Button fuelCalculateButton;
        private System.Windows.Forms.Label fuelKmPerLitInfo;
        private System.Windows.Forms.Label fuelLitPerKmInfo;
        private System.Windows.Forms.Label fuelKmPerLitLabel;
        private System.Windows.Forms.Label fuelLitPerKmLabel;
        private System.Windows.Forms.Label FuelCostLabel;
        private System.Windows.Forms.Label fuelLitPerSweMilLabel;
        private System.Windows.Forms.Label fuelLitPerMetricMileLabel;
        private System.Windows.Forms.Label fuelCostInfo;
        private System.Windows.Forms.Label fuelLitPerSweMilInfo;
        private System.Windows.Forms.Label fuelLitPerMetricMileInfo;
        private System.Windows.Forms.GroupBox bmiBox;
        private System.Windows.Forms.GroupBox bmiBoxResults;
        private System.Windows.Forms.Label bmiCategoryLabel;
        private System.Windows.Forms.Label bmiResultLabel;
        private System.Windows.Forms.Label bmiCategoryInfo;
        private System.Windows.Forms.Label bmiResultInfo;
        private System.Windows.Forms.Button bmiCalculateButton;
        private System.Windows.Forms.TextBox bmiWeightTextBox;
        private System.Windows.Forms.Label bmiWeightLabel;
        private System.Windows.Forms.Label bmiHeightLabel;
        private System.Windows.Forms.TextBox bmiHeightTextBox;
        private System.Windows.Forms.TextBox bmiNameTextBox;
        private System.Windows.Forms.Label bmiNameLabel;
        private System.Windows.Forms.RadioButton bmiUsRadioButton;
        private System.Windows.Forms.RadioButton bmiMetricRadioButton;
        private System.Windows.Forms.Label bmiNormalInfo;
    }
}

