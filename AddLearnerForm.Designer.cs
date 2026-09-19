namespace WinFormsApp1
{
    partial class AddLearnerForm
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
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            CourseComboBox = new ComboBox();
            Mark1 = new TextBox();
            Mark2 = new TextBox();
            Mark4 = new TextBox();
            Mark3 = new TextBox();
            Mark5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            AddButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(87, 44);
            FirstNameTextBox.Margin = new Padding(3, 2, 3, 2);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(218, 23);
            FirstNameTextBox.TabIndex = 0;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(87, 82);
            LastNameTextBox.Margin = new Padding(3, 2, 3, 2);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(218, 23);
            LastNameTextBox.TabIndex = 1;
            // 
            // CourseComboBox
            // 
            CourseComboBox.FormattingEnabled = true;
            CourseComboBox.Location = new Point(87, 119);
            CourseComboBox.Margin = new Padding(3, 2, 3, 2);
            CourseComboBox.Name = "CourseComboBox";
            CourseComboBox.Size = new Size(218, 23);
            CourseComboBox.TabIndex = 2;
            // 
            // Mark1
            // 
            Mark1.Location = new Point(355, 44);
            Mark1.Margin = new Padding(3, 2, 3, 2);
            Mark1.MaxLength = 3;
            Mark1.Name = "Mark1";
            Mark1.Size = new Size(44, 23);
            Mark1.TabIndex = 3;
            // 
            // Mark2
            // 
            Mark2.Location = new Point(355, 82);
            Mark2.Margin = new Padding(3, 2, 3, 2);
            Mark2.Name = "Mark2";
            Mark2.Size = new Size(44, 23);
            Mark2.TabIndex = 4;
            // 
            // Mark4
            // 
            Mark4.Location = new Point(355, 157);
            Mark4.Margin = new Padding(3, 2, 3, 2);
            Mark4.Name = "Mark4";
            Mark4.Size = new Size(44, 23);
            Mark4.TabIndex = 6;
            // 
            // Mark3
            // 
            Mark3.Location = new Point(355, 119);
            Mark3.Margin = new Padding(3, 2, 3, 2);
            Mark3.Name = "Mark3";
            Mark3.Size = new Size(44, 23);
            Mark3.TabIndex = 5;
            // 
            // Mark5
            // 
            Mark5.Location = new Point(355, 194);
            Mark5.Margin = new Padding(3, 2, 3, 2);
            Mark5.Name = "Mark5";
            Mark5.Size = new Size(44, 23);
            Mark5.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 8;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 9;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 119);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 10;
            label3.Text = "Course";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(332, 194);
            label4.Name = "label4";
            label4.Size = new Size(16, 15);
            label4.TabIndex = 11;
            label4.Text = "5.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(332, 156);
            label5.Name = "label5";
            label5.Size = new Size(16, 15);
            label5.TabIndex = 12;
            label5.Text = "4.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(332, 119);
            label6.Name = "label6";
            label6.Size = new Size(16, 15);
            label6.TabIndex = 13;
            label6.Text = "3.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(332, 82);
            label7.Name = "label7";
            label7.Size = new Size(16, 15);
            label7.TabIndex = 14;
            label7.Text = "2.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(332, 44);
            label8.Name = "label8";
            label8.Size = new Size(16, 15);
            label8.TabIndex = 15;
            label8.Text = "1.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(354, 17);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 16;
            label9.Text = "Marks:";
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.LimeGreen;
            AddButton.Location = new Point(223, 168);
            AddButton.Margin = new Padding(3, 2, 3, 2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(82, 22);
            AddButton.TabIndex = 17;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.Transparent;
            CancelButton.Location = new Point(223, 195);
            CancelButton.Margin = new Padding(3, 2, 3, 2);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(82, 22);
            CancelButton.TabIndex = 18;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddLearnerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 241);
            Controls.Add(CancelButton);
            Controls.Add(AddButton);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Mark5);
            Controls.Add(Mark4);
            Controls.Add(Mark3);
            Controls.Add(Mark2);
            Controls.Add(Mark1);
            Controls.Add(CourseComboBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddLearnerForm";
            Text = "Add Person";
            Load += AddLearnerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private ComboBox CourseComboBox;
        private TextBox Mark1;
        private TextBox Mark2;
        private TextBox Mark4;
        private TextBox Mark3;
        private TextBox Mark5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button AddButton;
        private Button CancelButton;
    }
}