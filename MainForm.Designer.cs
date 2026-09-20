namespace WinFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DisplayCourseDetailsButton = new Button();
            DisplayAllMarksButton = new Button();
            DisplayAllGradesButton = new Button();
            DisplayHighestMarksButton = new Button();
            DisplayLowestMarksButton = new Button();
            DisplayFailMarksButton = new Button();
            DisplayAverageMarksButton = new Button();
            DisplayAverageGradesButton = new Button();
            DisplayLecturerDetailsButton = new Button();
            AddLearnerButton = new Button();
            AddLecturerButton = new Button();
            RemoveLecturerButton = new Button();
            DataGridViewMain = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            label1 = new Label();
            PersonSearchTerm = new TextBox();
            PersonSearchButton = new Button();
            label2 = new Label();
            PersonComboBox = new ComboBox();
            groupBox5 = new GroupBox();
            label3 = new Label();
            CourseSearchTerm = new TextBox();
            CourseSearchButton = new Button();
            label4 = new Label();
            CourseComboBox = new ComboBox();
            groupBox6 = new GroupBox();
            label5 = new Label();
            StatisticsComboBox = new ComboBox();
            ComputeButton = new Button();
            groupBox7 = new GroupBox();
            MaxValue = new TextBox();
            label6 = new Label();
            MinValue = new TextBox();
            FilterButton = new Button();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // DisplayCourseDetailsButton
            // 
            DisplayCourseDetailsButton.BackColor = SystemColors.ControlLightLight;
            DisplayCourseDetailsButton.Location = new Point(8, 23);
            DisplayCourseDetailsButton.Margin = new Padding(4);
            DisplayCourseDetailsButton.Name = "DisplayCourseDetailsButton";
            DisplayCourseDetailsButton.Size = new Size(185, 22);
            DisplayCourseDetailsButton.TabIndex = 0;
            DisplayCourseDetailsButton.Text = "Display Course Details";
            DisplayCourseDetailsButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayCourseDetailsButton.UseVisualStyleBackColor = false;
            DisplayCourseDetailsButton.Click += DisplayCourseDetailsButton_Click;
            // 
            // DisplayAllMarksButton
            // 
            DisplayAllMarksButton.BackColor = SystemColors.ControlLightLight;
            DisplayAllMarksButton.Location = new Point(7, 23);
            DisplayAllMarksButton.Margin = new Padding(4);
            DisplayAllMarksButton.Name = "DisplayAllMarksButton";
            DisplayAllMarksButton.Size = new Size(188, 22);
            DisplayAllMarksButton.TabIndex = 1;
            DisplayAllMarksButton.Text = "Display All Marks";
            DisplayAllMarksButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayAllMarksButton.UseVisualStyleBackColor = false;
            DisplayAllMarksButton.Click += DisplayAllMarksButton_Click;
            // 
            // DisplayAllGradesButton
            // 
            DisplayAllGradesButton.BackColor = SystemColors.ControlLightLight;
            DisplayAllGradesButton.Location = new Point(7, 60);
            DisplayAllGradesButton.Margin = new Padding(4);
            DisplayAllGradesButton.Name = "DisplayAllGradesButton";
            DisplayAllGradesButton.Size = new Size(188, 22);
            DisplayAllGradesButton.TabIndex = 2;
            DisplayAllGradesButton.Text = "Display All Grades";
            DisplayAllGradesButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayAllGradesButton.UseVisualStyleBackColor = false;
            DisplayAllGradesButton.Click += DisplayAllGradesButton_Click;
            // 
            // DisplayHighestMarksButton
            // 
            DisplayHighestMarksButton.BackColor = SystemColors.ControlLightLight;
            DisplayHighestMarksButton.Location = new Point(7, 98);
            DisplayHighestMarksButton.Margin = new Padding(4);
            DisplayHighestMarksButton.Name = "DisplayHighestMarksButton";
            DisplayHighestMarksButton.Size = new Size(188, 22);
            DisplayHighestMarksButton.TabIndex = 3;
            DisplayHighestMarksButton.Text = "Display Highest Marks";
            DisplayHighestMarksButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayHighestMarksButton.UseVisualStyleBackColor = false;
            DisplayHighestMarksButton.Click += DisplayHighestMarksButton_Click;
            // 
            // DisplayLowestMarksButton
            // 
            DisplayLowestMarksButton.BackColor = SystemColors.ControlLightLight;
            DisplayLowestMarksButton.Location = new Point(7, 136);
            DisplayLowestMarksButton.Margin = new Padding(4);
            DisplayLowestMarksButton.Name = "DisplayLowestMarksButton";
            DisplayLowestMarksButton.Size = new Size(188, 22);
            DisplayLowestMarksButton.TabIndex = 4;
            DisplayLowestMarksButton.Text = "Display Lowest Marks";
            DisplayLowestMarksButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayLowestMarksButton.UseVisualStyleBackColor = false;
            DisplayLowestMarksButton.Click += DisplayLowestMarksButton_Click;
            // 
            // DisplayFailMarksButton
            // 
            DisplayFailMarksButton.BackColor = SystemColors.ControlLightLight;
            DisplayFailMarksButton.Location = new Point(7, 173);
            DisplayFailMarksButton.Margin = new Padding(4);
            DisplayFailMarksButton.Name = "DisplayFailMarksButton";
            DisplayFailMarksButton.Size = new Size(188, 22);
            DisplayFailMarksButton.TabIndex = 5;
            DisplayFailMarksButton.Text = "Display Fail Marks";
            DisplayFailMarksButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayFailMarksButton.UseVisualStyleBackColor = false;
            DisplayFailMarksButton.Click += DisplayFailMarksButton_Click;
            // 
            // DisplayAverageMarksButton
            // 
            DisplayAverageMarksButton.BackColor = SystemColors.ControlLightLight;
            DisplayAverageMarksButton.Location = new Point(7, 210);
            DisplayAverageMarksButton.Margin = new Padding(4);
            DisplayAverageMarksButton.Name = "DisplayAverageMarksButton";
            DisplayAverageMarksButton.Size = new Size(188, 22);
            DisplayAverageMarksButton.TabIndex = 6;
            DisplayAverageMarksButton.Text = "Display Average Marks";
            DisplayAverageMarksButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayAverageMarksButton.UseVisualStyleBackColor = false;
            DisplayAverageMarksButton.Click += DisplayAverageMarksButton_Click;
            // 
            // DisplayAverageGradesButton
            // 
            DisplayAverageGradesButton.BackColor = SystemColors.ControlLightLight;
            DisplayAverageGradesButton.Location = new Point(7, 248);
            DisplayAverageGradesButton.Margin = new Padding(4);
            DisplayAverageGradesButton.Name = "DisplayAverageGradesButton";
            DisplayAverageGradesButton.Size = new Size(188, 22);
            DisplayAverageGradesButton.TabIndex = 7;
            DisplayAverageGradesButton.Text = "Display Average Grades";
            DisplayAverageGradesButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayAverageGradesButton.UseVisualStyleBackColor = false;
            DisplayAverageGradesButton.Click += DisplayAverageGradesButton_Click;
            // 
            // DisplayLecturerDetailsButton
            // 
            DisplayLecturerDetailsButton.BackColor = SystemColors.ControlLightLight;
            DisplayLecturerDetailsButton.Location = new Point(7, 23);
            DisplayLecturerDetailsButton.Margin = new Padding(4);
            DisplayLecturerDetailsButton.Name = "DisplayLecturerDetailsButton";
            DisplayLecturerDetailsButton.Size = new Size(186, 22);
            DisplayLecturerDetailsButton.TabIndex = 8;
            DisplayLecturerDetailsButton.Text = "Display Lecturer Details";
            DisplayLecturerDetailsButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayLecturerDetailsButton.UseVisualStyleBackColor = false;
            DisplayLecturerDetailsButton.Click += DisplayLecturerDetailsButton_Click;
            // 
            // AddLearnerButton
            // 
            AddLearnerButton.BackColor = SystemColors.ControlLightLight;
            AddLearnerButton.Location = new Point(7, 287);
            AddLearnerButton.Margin = new Padding(4);
            AddLearnerButton.Name = "AddLearnerButton";
            AddLearnerButton.Size = new Size(188, 22);
            AddLearnerButton.TabIndex = 9;
            AddLearnerButton.Text = "Add Learner";
            AddLearnerButton.UseVisualStyleBackColor = false;
            AddLearnerButton.Click += AddLearnerButton_Click;
            // 
            // AddLecturerButton
            // 
            AddLecturerButton.BackColor = SystemColors.ControlLightLight;
            AddLecturerButton.Location = new Point(7, 53);
            AddLecturerButton.Margin = new Padding(4);
            AddLecturerButton.Name = "AddLecturerButton";
            AddLecturerButton.Size = new Size(93, 22);
            AddLecturerButton.TabIndex = 10;
            AddLecturerButton.Text = "Add";
            AddLecturerButton.TextAlign = ContentAlignment.MiddleLeft;
            AddLecturerButton.UseVisualStyleBackColor = false;
            AddLecturerButton.Click += AddLecturerButton_Click;
            // 
            // RemoveLecturerButton
            // 
            RemoveLecturerButton.BackColor = SystemColors.ControlLightLight;
            RemoveLecturerButton.Location = new Point(100, 53);
            RemoveLecturerButton.Margin = new Padding(4);
            RemoveLecturerButton.Name = "RemoveLecturerButton";
            RemoveLecturerButton.Size = new Size(93, 22);
            RemoveLecturerButton.TabIndex = 11;
            RemoveLecturerButton.Text = "Remove";
            RemoveLecturerButton.TextAlign = ContentAlignment.MiddleLeft;
            RemoveLecturerButton.UseVisualStyleBackColor = false;
            RemoveLecturerButton.Click += RemoveLecturerButton_Click;
            // 
            // DataGridViewMain
            // 
            DataGridViewMain.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewMain.GridColor = SystemColors.ControlDark;
            DataGridViewMain.Location = new Point(227, 12);
            DataGridViewMain.Margin = new Padding(3, 2, 3, 2);
            DataGridViewMain.Name = "DataGridViewMain";
            DataGridViewMain.RowHeadersWidth = 51;
            DataGridViewMain.Size = new Size(817, 485);
            DataGridViewMain.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(DisplayLecturerDetailsButton);
            groupBox1.Controls.Add(RemoveLecturerButton);
            groupBox1.Controls.Add(AddLecturerButton);
            groupBox1.Location = new Point(12, 410);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 87);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lecturers";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(DisplayAllMarksButton);
            groupBox2.Controls.Add(DisplayAllGradesButton);
            groupBox2.Controls.Add(DisplayHighestMarksButton);
            groupBox2.Controls.Add(AddLearnerButton);
            groupBox2.Controls.Add(DisplayLowestMarksButton);
            groupBox2.Controls.Add(DisplayAverageGradesButton);
            groupBox2.Controls.Add(DisplayFailMarksButton);
            groupBox2.Controls.Add(DisplayAverageMarksButton);
            groupBox2.Location = new Point(12, 78);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 326);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Learners";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Control;
            groupBox3.Controls.Add(DisplayCourseDetailsButton);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 60);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Courses";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(PersonSearchTerm);
            groupBox4.Controls.Add(PersonSearchButton);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(PersonComboBox);
            groupBox4.Location = new Point(227, 505);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(220, 128);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "Person";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 72);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 18;
            label1.Text = "Field";
            // 
            // PersonSearchTerm
            // 
            PersonSearchTerm.Location = new Point(6, 40);
            PersonSearchTerm.Name = "PersonSearchTerm";
            PersonSearchTerm.Size = new Size(202, 23);
            PersonSearchTerm.TabIndex = 19;
            // 
            // PersonSearchButton
            // 
            PersonSearchButton.BackColor = Color.Bisque;
            PersonSearchButton.Location = new Point(133, 90);
            PersonSearchButton.Name = "PersonSearchButton";
            PersonSearchButton.Size = new Size(75, 23);
            PersonSearchButton.TabIndex = 18;
            PersonSearchButton.Text = "Search";
            PersonSearchButton.UseVisualStyleBackColor = false;
            PersonSearchButton.Click += PersonSearchButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 22);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 20;
            label2.Text = "Term";
            // 
            // PersonComboBox
            // 
            PersonComboBox.FormattingEnabled = true;
            PersonComboBox.Items.AddRange(new object[] { "Firstname", "Lastname", "ID" });
            PersonComboBox.Location = new Point(6, 90);
            PersonComboBox.Name = "PersonComboBox";
            PersonComboBox.Size = new Size(121, 23);
            PersonComboBox.TabIndex = 18;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(CourseSearchTerm);
            groupBox5.Controls.Add(CourseSearchButton);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(CourseComboBox);
            groupBox5.Location = new Point(453, 505);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(220, 128);
            groupBox5.TabIndex = 21;
            groupBox5.TabStop = false;
            groupBox5.Text = "Course";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 72);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 18;
            label3.Text = "Field";
            // 
            // CourseSearchTerm
            // 
            CourseSearchTerm.Location = new Point(6, 40);
            CourseSearchTerm.Name = "CourseSearchTerm";
            CourseSearchTerm.Size = new Size(202, 23);
            CourseSearchTerm.TabIndex = 19;
            // 
            // CourseSearchButton
            // 
            CourseSearchButton.BackColor = Color.Bisque;
            CourseSearchButton.Location = new Point(133, 90);
            CourseSearchButton.Name = "CourseSearchButton";
            CourseSearchButton.Size = new Size(75, 23);
            CourseSearchButton.TabIndex = 18;
            CourseSearchButton.Text = "Search";
            CourseSearchButton.UseVisualStyleBackColor = false;
            CourseSearchButton.Click += CourseSearchButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 22);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 20;
            label4.Text = "Term";
            // 
            // CourseComboBox
            // 
            CourseComboBox.FormattingEnabled = true;
            CourseComboBox.Items.AddRange(new object[] { "Name", "Code" });
            CourseComboBox.Location = new Point(6, 90);
            CourseComboBox.Name = "CourseComboBox";
            CourseComboBox.Size = new Size(121, 23);
            CourseComboBox.TabIndex = 18;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label5);
            groupBox6.Controls.Add(StatisticsComboBox);
            groupBox6.Controls.Add(ComputeButton);
            groupBox6.Location = new Point(12, 505);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(200, 128);
            groupBox6.TabIndex = 22;
            groupBox6.TabStop = false;
            groupBox6.Text = "Statistics";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 22);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 2;
            label5.Text = "Option";
            // 
            // StatisticsComboBox
            // 
            StatisticsComboBox.FormattingEnabled = true;
            StatisticsComboBox.Items.AddRange(new object[] { "Average Salary" });
            StatisticsComboBox.Location = new Point(8, 40);
            StatisticsComboBox.Name = "StatisticsComboBox";
            StatisticsComboBox.Size = new Size(185, 23);
            StatisticsComboBox.TabIndex = 1;
            // 
            // ComputeButton
            // 
            ComputeButton.BackColor = Color.Bisque;
            ComputeButton.Location = new Point(8, 72);
            ComputeButton.Name = "ComputeButton";
            ComputeButton.Size = new Size(185, 41);
            ComputeButton.TabIndex = 0;
            ComputeButton.Text = "Compute";
            ComputeButton.UseVisualStyleBackColor = false;
            ComputeButton.Click += ComputeButton_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(label8);
            groupBox7.Controls.Add(label7);
            groupBox7.Controls.Add(MaxValue);
            groupBox7.Controls.Add(label6);
            groupBox7.Controls.Add(MinValue);
            groupBox7.Controls.Add(FilterButton);
            groupBox7.Location = new Point(679, 505);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(365, 128);
            groupBox7.TabIndex = 23;
            groupBox7.TabStop = false;
            groupBox7.Text = "Filter";
            // 
            // MaxValue
            // 
            MaxValue.Location = new Point(105, 40);
            MaxValue.Name = "MaxValue";
            MaxValue.Size = new Size(75, 23);
            MaxValue.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(87, 43);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 24;
            label6.Text = "-";
            // 
            // MinValue
            // 
            MinValue.Location = new Point(6, 40);
            MinValue.Name = "MinValue";
            MinValue.Size = new Size(75, 23);
            MinValue.TabIndex = 22;
            // 
            // FilterButton
            // 
            FilterButton.BackColor = Color.Bisque;
            FilterButton.Location = new Point(186, 40);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(75, 23);
            FilterButton.TabIndex = 21;
            FilterButton.Text = "Filter";
            FilterButton.UseVisualStyleBackColor = false;
            FilterButton.Click += FilterButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 22);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 29;
            label7.Text = "Min.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(105, 22);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 30;
            label8.Text = "Max.";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1056, 645);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(DataGridViewMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Project 1 - Ashton Scott";
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button DisplayCourseDetailsButton;
        private Button DisplayAllMarksButton;
        private Button DisplayAllGradesButton;
        private Button DisplayHighestMarksButton;
        private Button DisplayLowestMarksButton;
        private Button DisplayFailMarksButton;
        private Button DisplayAverageMarksButton;
        private Button DisplayAverageGradesButton;
        private Button DisplayLecturerDetailsButton;
        private Button AddLearnerButton;
        private Button AddLecturerButton;
        private Button RemoveLecturerButton;
        private DataGridView DataGridViewMain;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button PersonSearchButton;
        private Label label1;
        private ComboBox PersonComboBox;
        private TextBox PersonSearchTerm;
        private Label label2;
        private GroupBox groupBox5;
        private Label label3;
        private TextBox CourseSearchTerm;
        private Button CourseSearchButton;
        private Label label4;
        private ComboBox CourseComboBox;
        private GroupBox groupBox6;
        private Label label5;
        private ComboBox StatisticsComboBox;
        private Button ComputeButton;
        private GroupBox groupBox7;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button FilterButton;
        private Label label6;
        private TextBox MinValue;
        private TextBox MaxValue;
        private Label label8;
        private Label label7;
        private ComboBox comboBox3;
    }
}
