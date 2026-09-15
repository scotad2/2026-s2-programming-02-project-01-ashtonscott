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
            RemoveLearnerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).BeginInit();
            SuspendLayout();
            // 
            // DisplayCourseDetailsButton
            // 
            DisplayCourseDetailsButton.Location = new Point(15, 17);
            DisplayCourseDetailsButton.Margin = new Padding(5, 5, 5, 5);
            DisplayCourseDetailsButton.Name = "DisplayCourseDetailsButton";
            DisplayCourseDetailsButton.Size = new Size(215, 29);
            DisplayCourseDetailsButton.TabIndex = 0;
            DisplayCourseDetailsButton.Text = "Display Course Details";
            DisplayCourseDetailsButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayCourseDetailsButton.UseVisualStyleBackColor = true;
            DisplayCourseDetailsButton.Click += DisplayCourseDetailsButton_Click;
            // 
            // DisplayAllMarksButton
            // 
            DisplayAllMarksButton.Location = new Point(15, 67);
            DisplayAllMarksButton.Margin = new Padding(5, 5, 5, 5);
            DisplayAllMarksButton.Name = "DisplayAllMarksButton";
            DisplayAllMarksButton.Size = new Size(215, 29);
            DisplayAllMarksButton.TabIndex = 1;
            DisplayAllMarksButton.Text = "Display All Marks";
            DisplayAllMarksButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayAllMarksButton.UseVisualStyleBackColor = true;
            DisplayAllMarksButton.Click += DisplayAllMarksButton_Click;
            // 
            // DisplayAllGradesButton
            // 
            DisplayAllGradesButton.Location = new Point(15, 116);
            DisplayAllGradesButton.Margin = new Padding(5, 5, 5, 5);
            DisplayAllGradesButton.Name = "DisplayAllGradesButton";
            DisplayAllGradesButton.Size = new Size(215, 29);
            DisplayAllGradesButton.TabIndex = 2;
            DisplayAllGradesButton.Text = "Display All Grades";
            DisplayAllGradesButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayAllGradesButton.UseVisualStyleBackColor = true;
            DisplayAllGradesButton.Click += DisplayAllGradesButton_Click;
            // 
            // DisplayHighestMarksButton
            // 
            DisplayHighestMarksButton.Location = new Point(15, 167);
            DisplayHighestMarksButton.Margin = new Padding(5, 5, 5, 5);
            DisplayHighestMarksButton.Name = "DisplayHighestMarksButton";
            DisplayHighestMarksButton.Size = new Size(215, 29);
            DisplayHighestMarksButton.TabIndex = 3;
            DisplayHighestMarksButton.Text = "Display Highest Marks";
            DisplayHighestMarksButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayHighestMarksButton.UseVisualStyleBackColor = true;
            DisplayHighestMarksButton.Click += DisplayHighestMarksButton_Click;
            // 
            // DisplayLowestMarksButton
            // 
            DisplayLowestMarksButton.Location = new Point(15, 217);
            DisplayLowestMarksButton.Margin = new Padding(5, 5, 5, 5);
            DisplayLowestMarksButton.Name = "DisplayLowestMarksButton";
            DisplayLowestMarksButton.Size = new Size(215, 29);
            DisplayLowestMarksButton.TabIndex = 4;
            DisplayLowestMarksButton.Text = "Display Lowest Marks";
            DisplayLowestMarksButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayLowestMarksButton.UseVisualStyleBackColor = true;
            DisplayLowestMarksButton.Click += DisplayLowestMarksButton_Click;
            // 
            // DisplayFailMarksButton
            // 
            DisplayFailMarksButton.Location = new Point(15, 267);
            DisplayFailMarksButton.Margin = new Padding(5, 5, 5, 5);
            DisplayFailMarksButton.Name = "DisplayFailMarksButton";
            DisplayFailMarksButton.Size = new Size(215, 29);
            DisplayFailMarksButton.TabIndex = 5;
            DisplayFailMarksButton.Text = "Display Fail Marks";
            DisplayFailMarksButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayFailMarksButton.UseVisualStyleBackColor = true;
            DisplayFailMarksButton.Click += DisplayFailMarksButton_Click;
            // 
            // DisplayAverageMarksButton
            // 
            DisplayAverageMarksButton.Location = new Point(15, 316);
            DisplayAverageMarksButton.Margin = new Padding(5, 5, 5, 5);
            DisplayAverageMarksButton.Name = "DisplayAverageMarksButton";
            DisplayAverageMarksButton.Size = new Size(215, 29);
            DisplayAverageMarksButton.TabIndex = 6;
            DisplayAverageMarksButton.Text = "Display Average Marks";
            DisplayAverageMarksButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayAverageMarksButton.UseVisualStyleBackColor = true;
            DisplayAverageMarksButton.Click += DisplayAverageMarksButton_Click;
            // 
            // DisplayAverageGradesButton
            // 
            DisplayAverageGradesButton.Location = new Point(15, 367);
            DisplayAverageGradesButton.Margin = new Padding(5, 5, 5, 5);
            DisplayAverageGradesButton.Name = "DisplayAverageGradesButton";
            DisplayAverageGradesButton.Size = new Size(215, 29);
            DisplayAverageGradesButton.TabIndex = 7;
            DisplayAverageGradesButton.Text = "Display Average Grades";
            DisplayAverageGradesButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayAverageGradesButton.UseVisualStyleBackColor = true;
            DisplayAverageGradesButton.Click += DisplayAverageGradesButton_Click;
            // 
            // DisplayLecturerDetailsButton
            // 
            DisplayLecturerDetailsButton.Location = new Point(15, 417);
            DisplayLecturerDetailsButton.Margin = new Padding(5, 5, 5, 5);
            DisplayLecturerDetailsButton.Name = "DisplayLecturerDetailsButton";
            DisplayLecturerDetailsButton.Size = new Size(215, 29);
            DisplayLecturerDetailsButton.TabIndex = 8;
            DisplayLecturerDetailsButton.Text = "Display Lecturer Details";
            DisplayLecturerDetailsButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayLecturerDetailsButton.UseVisualStyleBackColor = true;
            DisplayLecturerDetailsButton.Click += DisplayLecturerDetailsButton_Click;
            // 
            // AddLearnerButton
            // 
            AddLearnerButton.Location = new Point(477, 669);
            AddLearnerButton.Margin = new Padding(5, 5, 5, 5);
            AddLearnerButton.Name = "AddLearnerButton";
            AddLearnerButton.Size = new Size(215, 29);
            AddLearnerButton.TabIndex = 9;
            AddLearnerButton.Text = "Add Learner";
            AddLearnerButton.TextAlign = ContentAlignment.MiddleLeft;
            AddLearnerButton.UseVisualStyleBackColor = true;
            AddLearnerButton.Click += AddLearnerButton_Click;
            // 
            // AddLecturerButton
            // 
            AddLecturerButton.Location = new Point(253, 669);
            AddLecturerButton.Margin = new Padding(5, 5, 5, 5);
            AddLecturerButton.Name = "AddLecturerButton";
            AddLecturerButton.Size = new Size(215, 29);
            AddLecturerButton.TabIndex = 10;
            AddLecturerButton.Text = "Add Lecturer";
            AddLecturerButton.TextAlign = ContentAlignment.MiddleLeft;
            AddLecturerButton.UseVisualStyleBackColor = true;
            AddLecturerButton.Click += AddLecturerButton_Click;
            // 
            // RemoveLecturerButton
            // 
            RemoveLecturerButton.Location = new Point(253, 709);
            RemoveLecturerButton.Margin = new Padding(5, 5, 5, 5);
            RemoveLecturerButton.Name = "RemoveLecturerButton";
            RemoveLecturerButton.Size = new Size(215, 29);
            RemoveLecturerButton.TabIndex = 11;
            RemoveLecturerButton.Text = "Remove Lecturer";
            RemoveLecturerButton.TextAlign = ContentAlignment.MiddleLeft;
            RemoveLecturerButton.UseVisualStyleBackColor = true;
            RemoveLecturerButton.Click += RemoveLecturerButton_Click;
            // 
            // DataGridViewMain
            // 
            DataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewMain.Location = new Point(253, 17);
            DataGridViewMain.Name = "DataGridViewMain";
            DataGridViewMain.RowHeadersWidth = 51;
            DataGridViewMain.Size = new Size(914, 629);
            DataGridViewMain.TabIndex = 13;
            // 
            // RemoveLearnerButton
            // 
            RemoveLearnerButton.Location = new Point(477, 709);
            RemoveLearnerButton.Margin = new Padding(5, 5, 5, 5);
            RemoveLearnerButton.Name = "RemoveLearnerButton";
            RemoveLearnerButton.Size = new Size(215, 29);
            RemoveLearnerButton.TabIndex = 14;
            RemoveLearnerButton.Text = "Remove Learner";
            RemoveLearnerButton.TextAlign = ContentAlignment.MiddleLeft;
            RemoveLearnerButton.UseVisualStyleBackColor = true;
            RemoveLearnerButton.Click += RemoveLearnerButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 755);
            Controls.Add(RemoveLearnerButton);
            Controls.Add(DataGridViewMain);
            Controls.Add(RemoveLecturerButton);
            Controls.Add(AddLecturerButton);
            Controls.Add(AddLearnerButton);
            Controls.Add(DisplayLecturerDetailsButton);
            Controls.Add(DisplayAverageGradesButton);
            Controls.Add(DisplayAverageMarksButton);
            Controls.Add(DisplayFailMarksButton);
            Controls.Add(DisplayLowestMarksButton);
            Controls.Add(DisplayHighestMarksButton);
            Controls.Add(DisplayAllGradesButton);
            Controls.Add(DisplayAllMarksButton);
            Controls.Add(DisplayCourseDetailsButton);
            Name = "Form1";
            Text = "Project 1 - Ashton Scott";
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).EndInit();
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
        private Button RemoveLearnerButton;
    }
}
