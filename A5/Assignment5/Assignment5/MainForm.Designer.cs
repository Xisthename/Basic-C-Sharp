namespace Assignment5
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
            this.itemListView = new System.Windows.Forms.ListView();
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inputBox = new System.Windows.Forms.GroupBox();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.UnitTypesComboBox = new System.Windows.Forms.ComboBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.inputBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // itemListView
            // 
            this.itemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDescription,
            this.ColumnAmount,
            this.columnUnit});
            this.itemListView.FullRowSelect = true;
            this.itemListView.GridLines = true;
            this.itemListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.itemListView.HideSelection = false;
            this.itemListView.Location = new System.Drawing.Point(12, 155);
            this.itemListView.MultiSelect = false;
            this.itemListView.Name = "itemListView";
            this.itemListView.Size = new System.Drawing.Size(470, 200);
            this.itemListView.TabIndex = 14;
            this.itemListView.UseCompatibleStateImageBehavior = false;
            this.itemListView.View = System.Windows.Forms.View.Details;
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Description";
            this.columnDescription.Width = 200;
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.Text = "Amount";
            this.ColumnAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnUnit
            // 
            this.columnUnit.Text = "Unit";
            this.columnUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnUnit.Width = 85;
            // 
            // inputBox
            // 
            this.inputBox.Controls.Add(this.amountNumericUpDown);
            this.inputBox.Controls.Add(this.UnitTypesComboBox);
            this.inputBox.Controls.Add(this.amountLabel);
            this.inputBox.Controls.Add(this.descriptionLabel);
            this.inputBox.Controls.Add(this.descriptionTextBox);
            this.inputBox.Location = new System.Drawing.Point(12, 12);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(360, 137);
            this.inputBox.TabIndex = 15;
            this.inputBox.TabStop = false;
            this.inputBox.Text = "Input";
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.DecimalPlaces = 2;
            this.amountNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.amountNumericUpDown.Location = new System.Drawing.Point(94, 82);
            this.amountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(164, 22);
            this.amountNumericUpDown.TabIndex = 5;
            this.amountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UnitTypesComboBox
            // 
            this.UnitTypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnitTypesComboBox.FormattingEnabled = true;
            this.UnitTypesComboBox.Location = new System.Drawing.Point(264, 81);
            this.UnitTypesComboBox.Name = "UnitTypesComboBox";
            this.UnitTypesComboBox.Size = new System.Drawing.Size(90, 24);
            this.UnitTypesComboBox.TabIndex = 4;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(9, 85);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(56, 17);
            this.amountLabel.TabIndex = 3;
            this.amountLabel.Text = "Amount";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(9, 43);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(94, 40);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(260, 22);
            this.descriptionTextBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(378, 22);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(104, 35);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(378, 68);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(104, 35);
            this.editButton.TabIndex = 17;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(378, 114);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(104, 35);
            this.removeButton.TabIndex = 18;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 363);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.itemListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "The shopping List";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.inputBox.ResumeLayout(false);
            this.inputBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView itemListView;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.ColumnHeader ColumnAmount;
        private System.Windows.Forms.ColumnHeader columnUnit;
        private System.Windows.Forms.GroupBox inputBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox UnitTypesComboBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
    }
}

