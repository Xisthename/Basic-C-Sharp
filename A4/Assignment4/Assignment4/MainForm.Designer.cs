namespace Assignment4
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
            this.newRecipeBox = new System.Windows.Forms.GroupBox();
            this.AddRecipeButton = new System.Windows.Forms.Button();
            this.newRecipeNameTextBox = new System.Windows.Forms.TextBox();
            this.AddIngredientsButton = new System.Windows.Forms.Button();
            this.newRecpieCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.newRecipeDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.newRecipeCategoryInfo = new System.Windows.Forms.Label();
            this.newRecipeNameInfo = new System.Windows.Forms.Label();
            this.recpieListBox = new System.Windows.Forms.ListBox();
            this.NameInfo = new System.Windows.Forms.Label();
            this.ingredientsInfo = new System.Windows.Forms.Label();
            this.categoryInfo = new System.Windows.Forms.Label();
            this.descriptionInfo = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.newRecipeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newRecipeBox
            // 
            this.newRecipeBox.Controls.Add(this.AddRecipeButton);
            this.newRecipeBox.Controls.Add(this.newRecipeNameTextBox);
            this.newRecipeBox.Controls.Add(this.AddIngredientsButton);
            this.newRecipeBox.Controls.Add(this.newRecpieCategoryComboBox);
            this.newRecipeBox.Controls.Add(this.newRecipeDescriptionTextBox);
            this.newRecipeBox.Controls.Add(this.newRecipeCategoryInfo);
            this.newRecipeBox.Controls.Add(this.newRecipeNameInfo);
            this.newRecipeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.newRecipeBox.Location = new System.Drawing.Point(13, 13);
            this.newRecipeBox.Name = "newRecipeBox";
            this.newRecipeBox.Size = new System.Drawing.Size(420, 410);
            this.newRecipeBox.TabIndex = 0;
            this.newRecipeBox.TabStop = false;
            this.newRecipeBox.Text = "Add new recipe";
            // 
            // AddRecipeButton
            // 
            this.AddRecipeButton.Location = new System.Drawing.Point(10, 367);
            this.AddRecipeButton.Name = "AddRecipeButton";
            this.AddRecipeButton.Size = new System.Drawing.Size(400, 35);
            this.AddRecipeButton.TabIndex = 6;
            this.AddRecipeButton.Text = "Add Recipe";
            this.AddRecipeButton.UseVisualStyleBackColor = true;
            this.AddRecipeButton.Click += new System.EventHandler(this.AddRecipeButton_Click);
            // 
            // newRecipeNameTextBox
            // 
            this.newRecipeNameTextBox.Location = new System.Drawing.Point(140, 38);
            this.newRecipeNameTextBox.Name = "newRecipeNameTextBox";
            this.newRecipeNameTextBox.Size = new System.Drawing.Size(270, 27);
            this.newRecipeNameTextBox.TabIndex = 5;
            // 
            // AddIngredientsButton
            // 
            this.AddIngredientsButton.Location = new System.Drawing.Point(250, 73);
            this.AddIngredientsButton.Name = "AddIngredientsButton";
            this.AddIngredientsButton.Size = new System.Drawing.Size(160, 32);
            this.AddIngredientsButton.TabIndex = 4;
            this.AddIngredientsButton.Text = "Add ingredients";
            this.AddIngredientsButton.UseVisualStyleBackColor = true;
            this.AddIngredientsButton.Click += new System.EventHandler(this.AddIngredientsButton_Click);
            // 
            // newRecpieCategoryComboBox
            // 
            this.newRecpieCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newRecpieCategoryComboBox.FormattingEnabled = true;
            this.newRecpieCategoryComboBox.Location = new System.Drawing.Point(94, 73);
            this.newRecpieCategoryComboBox.Name = "newRecpieCategoryComboBox";
            this.newRecpieCategoryComboBox.Size = new System.Drawing.Size(150, 28);
            this.newRecpieCategoryComboBox.TabIndex = 3;
            // 
            // newRecipeDescriptionTextBox
            // 
            this.newRecipeDescriptionTextBox.Location = new System.Drawing.Point(10, 111);
            this.newRecipeDescriptionTextBox.Multiline = true;
            this.newRecipeDescriptionTextBox.Name = "newRecipeDescriptionTextBox";
            this.newRecipeDescriptionTextBox.Size = new System.Drawing.Size(400, 250);
            this.newRecipeDescriptionTextBox.TabIndex = 2;
            // 
            // newRecipeCategoryInfo
            // 
            this.newRecipeCategoryInfo.AutoSize = true;
            this.newRecipeCategoryInfo.Location = new System.Drawing.Point(6, 76);
            this.newRecipeCategoryInfo.Name = "newRecipeCategoryInfo";
            this.newRecipeCategoryInfo.Size = new System.Drawing.Size(76, 20);
            this.newRecipeCategoryInfo.TabIndex = 1;
            this.newRecipeCategoryInfo.Text = "Category";
            // 
            // newRecipeNameInfo
            // 
            this.newRecipeNameInfo.AutoSize = true;
            this.newRecipeNameInfo.Location = new System.Drawing.Point(6, 41);
            this.newRecipeNameInfo.Name = "newRecipeNameInfo";
            this.newRecipeNameInfo.Size = new System.Drawing.Size(123, 20);
            this.newRecipeNameInfo.TabIndex = 0;
            this.newRecipeNameInfo.Text = "Name of recipe";
            // 
            // recpieListBox
            // 
            this.recpieListBox.FormattingEnabled = true;
            this.recpieListBox.ItemHeight = 16;
            this.recpieListBox.Location = new System.Drawing.Point(443, 51);
            this.recpieListBox.Name = "recpieListBox";
            this.recpieListBox.Size = new System.Drawing.Size(477, 324);
            this.recpieListBox.TabIndex = 1;
            // 
            // NameInfo
            // 
            this.NameInfo.AutoSize = true;
            this.NameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.NameInfo.Location = new System.Drawing.Point(439, 28);
            this.NameInfo.Name = "NameInfo";
            this.NameInfo.Size = new System.Drawing.Size(53, 20);
            this.NameInfo.TabIndex = 7;
            this.NameInfo.Text = "Name";
            // 
            // ingredientsInfo
            // 
            this.ingredientsInfo.AutoSize = true;
            this.ingredientsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.ingredientsInfo.Location = new System.Drawing.Point(554, 28);
            this.ingredientsInfo.Name = "ingredientsInfo";
            this.ingredientsInfo.Size = new System.Drawing.Size(91, 20);
            this.ingredientsInfo.TabIndex = 8;
            this.ingredientsInfo.Text = "Ingredients";
            // 
            // categoryInfo
            // 
            this.categoryInfo.AutoSize = true;
            this.categoryInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.categoryInfo.Location = new System.Drawing.Point(695, 28);
            this.categoryInfo.Name = "categoryInfo";
            this.categoryInfo.Size = new System.Drawing.Size(76, 20);
            this.categoryInfo.TabIndex = 9;
            this.categoryInfo.Text = "Category";
            // 
            // descriptionInfo
            // 
            this.descriptionInfo.AutoSize = true;
            this.descriptionInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.descriptionInfo.Location = new System.Drawing.Point(820, 28);
            this.descriptionInfo.Name = "descriptionInfo";
            this.descriptionInfo.Size = new System.Drawing.Size(95, 20);
            this.descriptionInfo.TabIndex = 10;
            this.descriptionInfo.Text = "Description";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.deleteButton.Location = new System.Drawing.Point(820, 380);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 35);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.editButton.Location = new System.Drawing.Point(443, 380);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 35);
            this.editButton.TabIndex = 11;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 428);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.descriptionInfo);
            this.Controls.Add(this.categoryInfo);
            this.Controls.Add(this.ingredientsInfo);
            this.Controls.Add(this.NameInfo);
            this.Controls.Add(this.recpieListBox);
            this.Controls.Add(this.newRecipeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Apu\'s Cook Book";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.newRecipeBox.ResumeLayout(false);
            this.newRecipeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox newRecipeBox;
        private System.Windows.Forms.ComboBox newRecpieCategoryComboBox;
        private System.Windows.Forms.TextBox newRecipeDescriptionTextBox;
        private System.Windows.Forms.Label newRecipeCategoryInfo;
        private System.Windows.Forms.Label newRecipeNameInfo;
        private System.Windows.Forms.Button AddRecipeButton;
        private System.Windows.Forms.TextBox newRecipeNameTextBox;
        private System.Windows.Forms.Button AddIngredientsButton;
        private System.Windows.Forms.ListBox recpieListBox;
        private System.Windows.Forms.Label NameInfo;
        private System.Windows.Forms.Label ingredientsInfo;
        private System.Windows.Forms.Label categoryInfo;
        private System.Windows.Forms.Label descriptionInfo;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
    }
}

