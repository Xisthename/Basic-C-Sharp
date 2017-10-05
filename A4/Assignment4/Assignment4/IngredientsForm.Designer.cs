namespace Assignment4
{
    partial class IngredientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientsForm));
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.ingredientBox = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.ingredientsListBox = new System.Windows.Forms.ListBox();
            this.ingredientTextBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.addIngredientButton = new System.Windows.Forms.Button();
            this.ingredientBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.okButton.Location = new System.Drawing.Point(247, 330);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 35);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cancelButton.Location = new System.Drawing.Point(353, 330);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 35);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.ingredientsLabel.Location = new System.Drawing.Point(18, 14);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(193, 20);
            this.ingredientsLabel.TabIndex = 2;
            this.ingredientsLabel.Text = "Number of ingredients: 0";
            // 
            // ingredientBox
            // 
            this.ingredientBox.Controls.Add(this.deleteButton);
            this.ingredientBox.Controls.Add(this.ingredientsListBox);
            this.ingredientBox.Controls.Add(this.ingredientTextBox);
            this.ingredientBox.Controls.Add(this.editButton);
            this.ingredientBox.Controls.Add(this.cancelButton);
            this.ingredientBox.Controls.Add(this.addIngredientButton);
            this.ingredientBox.Controls.Add(this.okButton);
            this.ingredientBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.ingredientBox.Location = new System.Drawing.Point(12, 37);
            this.ingredientBox.Name = "ingredientBox";
            this.ingredientBox.Size = new System.Drawing.Size(460, 375);
            this.ingredientBox.TabIndex = 3;
            this.ingredientBox.TabStop = false;
            this.ingredientBox.Text = "Ingredient";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.deleteButton.Location = new System.Drawing.Point(113, 330);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 35);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ingredientsListBox
            // 
            this.ingredientsListBox.FormattingEnabled = true;
            this.ingredientsListBox.ItemHeight = 20;
            this.ingredientsListBox.Location = new System.Drawing.Point(7, 60);
            this.ingredientsListBox.Name = "ingredientsListBox";
            this.ingredientsListBox.Size = new System.Drawing.Size(446, 264);
            this.ingredientsListBox.TabIndex = 7;
            // 
            // ingredientTextBox
            // 
            this.ingredientTextBox.Location = new System.Drawing.Point(6, 26);
            this.ingredientTextBox.Name = "ingredientTextBox";
            this.ingredientTextBox.Size = new System.Drawing.Size(366, 27);
            this.ingredientTextBox.TabIndex = 6;
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.editButton.Location = new System.Drawing.Point(7, 330);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 35);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addIngredientButton
            // 
            this.addIngredientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.addIngredientButton.Location = new System.Drawing.Point(378, 26);
            this.addIngredientButton.Name = "addIngredientButton";
            this.addIngredientButton.Size = new System.Drawing.Size(75, 28);
            this.addIngredientButton.TabIndex = 5;
            this.addIngredientButton.Text = "Add";
            this.addIngredientButton.UseVisualStyleBackColor = true;
            this.addIngredientButton.Click += new System.EventHandler(this.addIngredientButton_Click);
            // 
            // IngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 419);
            this.Controls.Add(this.ingredientBox);
            this.Controls.Add(this.ingredientsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IngredientsForm";
            this.Text = "Add Ingredients";
            this.ingredientBox.ResumeLayout(false);
            this.ingredientBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.GroupBox ingredientBox;
        private System.Windows.Forms.ListBox ingredientsListBox;
        private System.Windows.Forms.TextBox ingredientTextBox;
        private System.Windows.Forms.Button addIngredientButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
    }
}