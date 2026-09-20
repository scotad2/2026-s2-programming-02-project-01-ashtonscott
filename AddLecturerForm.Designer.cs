namespace WinFormsApp1
{
    partial class AddLecturerForm
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CourseComboBox = new ComboBox();
            LastNameTextBox = new TextBox();
            FirstNameTextBox = new TextBox();
            PositionComboBox = new ComboBox();
            CancelButton = new Button();
            AddButton = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 131);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 16;
            label3.Text = "Course";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 15;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 14;
            label1.Text = "First Name";
            // 
            // CourseComboBox
            // 
            CourseComboBox.FormattingEnabled = true;
            CourseComboBox.Location = new Point(12, 151);
            CourseComboBox.Margin = new Padding(3, 2, 3, 2);
            CourseComboBox.Name = "CourseComboBox";
            CourseComboBox.Size = new Size(218, 23);
            CourseComboBox.TabIndex = 13;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(12, 87);
            LastNameTextBox.Margin = new Padding(3, 2, 3, 2);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(298, 23);
            LastNameTextBox.TabIndex = 12;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(12, 45);
            FirstNameTextBox.Margin = new Padding(3, 2, 3, 2);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(298, 23);
            FirstNameTextBox.TabIndex = 11;
            // 
            // PositionComboBox
            // 
            PositionComboBox.FormattingEnabled = true;
            PositionComboBox.Location = new Point(12, 193);
            PositionComboBox.Margin = new Padding(3, 2, 3, 2);
            PositionComboBox.Name = "PositionComboBox";
            PositionComboBox.Size = new Size(218, 23);
            PositionComboBox.TabIndex = 17;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.Transparent;
            CancelButton.Location = new Point(263, 194);
            CancelButton.Margin = new Padding(3, 2, 3, 2);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(82, 22);
            CancelButton.TabIndex = 20;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.DarkSeaGreen;
            AddButton.Location = new Point(263, 168);
            AddButton.Margin = new Padding(3, 2, 3, 2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(82, 22);
            AddButton.TabIndex = 19;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 176);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 21;
            label4.Text = "Position";
            // 
            // AddLecturerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 241);
            Controls.Add(label4);
            Controls.Add(CancelButton);
            Controls.Add(AddButton);
            Controls.Add(PositionComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CourseComboBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Name = "AddLecturerForm";
            Text = "Add Lecturer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox CourseComboBox;
        private TextBox LastNameTextBox;
        private TextBox FirstNameTextBox;
        private ComboBox PositionComboBox;
        private Button CancelButton;
        private Button AddButton;
        private Label label4;
    }
}