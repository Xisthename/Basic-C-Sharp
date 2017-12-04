namespace Assignment6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dateAndTimeInfo = new System.Windows.Forms.Label();
            this.priorityInfo = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.toDoInfo = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toDoTextBox = new System.Windows.Forms.TextBox();
            this.taskListView = new System.Windows.Forms.ListView();
            this.ColumnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.updateClock = new System.Windows.Forms.Timer(this.components);
            this.TimeInfo = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateAndTimeInfo
            // 
            this.dateAndTimeInfo.AutoSize = true;
            this.dateAndTimeInfo.Location = new System.Drawing.Point(8, 45);
            this.dateAndTimeInfo.Name = "dateAndTimeInfo";
            this.dateAndTimeInfo.Size = new System.Drawing.Size(100, 17);
            this.dateAndTimeInfo.TabIndex = 0;
            this.dateAndTimeInfo.Text = "Date and time:";
            // 
            // priorityInfo
            // 
            this.priorityInfo.AutoSize = true;
            this.priorityInfo.Location = new System.Drawing.Point(301, 45);
            this.priorityInfo.Name = "priorityInfo";
            this.priorityInfo.Size = new System.Drawing.Size(56, 17);
            this.priorityInfo.TabIndex = 1;
            this.priorityInfo.Text = "Priority:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy-MM-dd     hh:mm";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(112, 43);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(183, 22);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.Value = new System.DateTime(2017, 11, 26, 0, 0, 0, 0);
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Location = new System.Drawing.Point(363, 42);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(131, 24);
            this.priorityComboBox.TabIndex = 3;
            // 
            // toDoInfo
            // 
            this.toDoInfo.AutoSize = true;
            this.toDoInfo.Location = new System.Drawing.Point(8, 78);
            this.toDoInfo.Name = "toDoInfo";
            this.toDoInfo.Size = new System.Drawing.Size(47, 17);
            this.toDoInfo.TabIndex = 4;
            this.toDoInfo.Text = "To Do";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(652, 28);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.newToolStripMenuItem.Text = "New     Ctrl + N";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.exitToolStripMenuItem.Text = "Exit       Alt + F4";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toDoTextBox
            // 
            this.toDoTextBox.Location = new System.Drawing.Point(112, 78);
            this.toDoTextBox.Name = "toDoTextBox";
            this.toDoTextBox.Size = new System.Drawing.Size(382, 22);
            this.toDoTextBox.TabIndex = 6;
            // 
            // taskListView
            // 
            this.taskListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnDate,
            this.columnTime,
            this.columnPriority,
            this.columnDescription});
            this.taskListView.FullRowSelect = true;
            this.taskListView.GridLines = true;
            this.taskListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.taskListView.HideSelection = false;
            this.taskListView.Location = new System.Drawing.Point(12, 119);
            this.taskListView.MultiSelect = false;
            this.taskListView.Name = "taskListView";
            this.taskListView.Size = new System.Drawing.Size(630, 200);
            this.taskListView.TabIndex = 15;
            this.taskListView.UseCompatibleStateImageBehavior = false;
            this.taskListView.View = System.Windows.Forms.View.Details;
            // 
            // ColumnDate
            // 
            this.ColumnDate.Text = "Date";
            this.ColumnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnDate.Width = 100;
            // 
            // columnTime
            // 
            this.columnTime.Text = "Time";
            this.columnTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTime.Width = 70;
            // 
            // columnPriority
            // 
            this.columnPriority.Text = "Priority";
            this.columnPriority.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPriority.Width = 100;
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Description";
            this.columnDescription.Width = 200;
            // 
            // updateClock
            // 
            this.updateClock.Enabled = true;
            this.updateClock.Interval = 1000;
            this.updateClock.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // TimeInfo
            // 
            this.TimeInfo.AutoSize = true;
            this.TimeInfo.Location = new System.Drawing.Point(500, 46);
            this.TimeInfo.Name = "TimeInfo";
            this.TimeInfo.Size = new System.Drawing.Size(142, 17);
            this.TimeInfo.TabIndex = 16;
            this.TimeInfo.Text = "Time spent: 00:00:00";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(500, 78);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(142, 30);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 328);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.TimeInfo);
            this.Controls.Add(this.taskListView);
            this.Controls.Add(this.toDoTextBox);
            this.Controls.Add(this.toDoInfo);
            this.Controls.Add(this.priorityComboBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.priorityInfo);
            this.Controls.Add(this.dateAndTimeInfo);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "To Do Reminder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateAndTimeInfo;
        private System.Windows.Forms.Label priorityInfo;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox priorityComboBox;
        private System.Windows.Forms.Label toDoInfo;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox toDoTextBox;
        private System.Windows.Forms.ListView taskListView;
        private System.Windows.Forms.ColumnHeader ColumnDate;
        private System.Windows.Forms.ColumnHeader columnTime;
        private System.Windows.Forms.ColumnHeader columnPriority;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.Timer updateClock;
        private System.Windows.Forms.Label TimeInfo;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

