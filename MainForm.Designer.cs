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
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).BeginInit();
            SuspendLayout();
            // 
            // DisplayCourseDetailsButton
            // 
            DisplayCourseDetailsButton.Location = new Point(13, 13);
            DisplayCourseDetailsButton.Margin = new Padding(4, 4, 4, 4);
            DisplayCourseDetailsButton.Name = "DisplayCourseDetailsButton";
            DisplayCourseDetailsButton.Size = new Size(188, 22);
            DisplayCourseDetailsButton.TabIndex = 0;
            DisplayCourseDetailsButton.Text = "Display Course Details";
            DisplayCourseDetailsButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayCourseDetailsButton.UseVisualStyleBackColor = true;
            DisplayCourseDetailsButton.Click += DisplayCourseDetailsButton_Click;
            // 
            // DisplayAllMarksButton
            // 
            DisplayAllMarksButton.Location = new Point(13, 50);
            DisplayAllMarksButton.Margin = new Padding(4, 4, 4, 4);
            DisplayAllMarksButton.Name = "DisplayAllMarksButton";
            DisplayAllMarksButton.Size = new Size(188, 22);
            DisplayAllMarksButton.TabIndex = 1;
            DisplayAllMarksButton.Text = "Display All Marks";
            DisplayAllMarksButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayAllMarksButton.UseVisualStyleBackColor = true;
            DisplayAllMarksButton.Click += DisplayAllMarksButton_Click;
            // 
            // DisplayAllGradesButton
            // 
            DisplayAllGradesButton.Location = new Point(13, 87);
            DisplayAllGradesButton.Margin = new Padding(4, 4, 4, 4);
            DisplayAllGradesButton.Name = "DisplayAllGradesButton";
            DisplayAllGradesButton.Size = new Size(188, 22);
            DisplayAllGradesButton.TabIndex = 2;
            DisplayAllGradesButton.Text = "Display All Grades";
            DisplayAllGradesButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayAllGradesButton.UseVisualStyleBackColor = true;
            DisplayAllGradesButton.Click += DisplayAllGradesButton_Click;
            // 
            // DisplayHighestMarksButton
            // 
            DisplayHighestMarksButton.Location = new Point(13, 125);
            DisplayHighestMarksButton.Margin = new Padding(4, 4, 4, 4);
            DisplayHighestMarksButton.Name = "DisplayHighestMarksButton";
            DisplayHighestMarksButton.Size = new Size(188, 22);
            DisplayHighestMarksButton.TabIndex = 3;
            DisplayHighestMarksButton.Text = "Display Highest Marks";
            DisplayHighestMarksButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayHighestMarksButton.UseVisualStyleBackColor = true;
            DisplayHighestMarksButton.Click += DisplayHighestMarksButton_Click;
            // 
            // DisplayLowestMarksButton
            // 
            DisplayLowestMarksButton.Location = new Point(13, 163);
            DisplayLowestMarksButton.Margin = new Padding(4, 4, 4, 4);
            DisplayLowestMarksButton.Name = "DisplayLowestMarksButton";
            DisplayLowestMarksButton.Size = new Size(188, 22);
            DisplayLowestMarksButton.TabIndex = 4;
            DisplayLowestMarksButton.Text = "Display Lowest Marks";
            DisplayLowestMarksButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayLowestMarksButton.UseVisualStyleBackColor = true;
            DisplayLowestMarksButton.Click += DisplayLowestMarksButton_Click;
            // 
            // DisplayFailMarksButton
            // 
            DisplayFailMarksButton.Location = new Point(13, 200);
            DisplayFailMarksButton.Margin = new Padding(4, 4, 4, 4);
            DisplayFailMarksButton.Name = "DisplayFailMarksButton";
            DisplayFailMarksButton.Size = new Size(188, 22);
            DisplayFailMarksButton.TabIndex = 5;
            DisplayFailMarksButton.Text = "Display Fail Marks";
            DisplayFailMarksButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayFailMarksButton.UseVisualStyleBackColor = true;
            DisplayFailMarksButton.Click += DisplayFailMarksButton_Click;
            // 
            // DisplayAverageMarksButton
            // 
            DisplayAverageMarksButton.Location = new Point(13, 237);
            DisplayAverageMarksButton.Margin = new Padding(4, 4, 4, 4);
            DisplayAverageMarksButton.Name = "DisplayAverageMarksButton";
            DisplayAverageMarksButton.Size = new Size(188, 22);
            DisplayAverageMarksButton.TabIndex = 6;
            DisplayAverageMarksButton.Text = "Display Average Marks";
            DisplayAverageMarksButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayAverageMarksButton.UseVisualStyleBackColor = true;
            DisplayAverageMarksButton.Click += DisplayAverageMarksButton_Click;
            // 
            // DisplayAverageGradesButton
            // 
            DisplayAverageGradesButton.Location = new Point(13, 275);
            DisplayAverageGradesButton.Margin = new Padding(4, 4, 4, 4);
            DisplayAverageGradesButton.Name = "DisplayAverageGradesButton";
            DisplayAverageGradesButton.Size = new Size(188, 22);
            DisplayAverageGradesButton.TabIndex = 7;
            DisplayAverageGradesButton.Text = "Display Average Grades";
            DisplayAverageGradesButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayAverageGradesButton.UseVisualStyleBackColor = true;
            DisplayAverageGradesButton.Click += DisplayAverageGradesButton_Click;
            // 
            // DisplayLecturerDetailsButton
            // 
            DisplayLecturerDetailsButton.Location = new Point(13, 313);
            DisplayLecturerDetailsButton.Margin = new Padding(4, 4, 4, 4);
            DisplayLecturerDetailsButton.Name = "DisplayLecturerDetailsButton";
            DisplayLecturerDetailsButton.Size = new Size(188, 22);
            DisplayLecturerDetailsButton.TabIndex = 8;
            DisplayLecturerDetailsButton.Text = "Display Lecturer Details";
            DisplayLecturerDetailsButton.TextAlign = ContentAlignment.MiddleLeft;
            DisplayLecturerDetailsButton.UseVisualStyleBackColor = true;
            DisplayLecturerDetailsButton.Click += DisplayLecturerDetailsButton_Click;
            // 
            // AddLearnerButton
            // 
            AddLearnerButton.Location = new Point(417, 502);
            AddLearnerButton.Margin = new Padding(4, 4, 4, 4);
            AddLearnerButton.Name = "AddLearnerButton";
            AddLearnerButton.Size = new Size(188, 22);
            AddLearnerButton.TabIndex = 9;
            AddLearnerButton.Text = "Add Learner";
            AddLearnerButton.TextAlign = ContentAlignment.MiddleLeft;
            AddLearnerButton.UseVisualStyleBackColor = true;
            AddLearnerButton.Click += AddLearnerButton_Click;
            // 
            // AddLecturerButton
            // 
            AddLecturerButton.Location = new Point(221, 502);
            AddLecturerButton.Margin = new Padding(4, 4, 4, 4);
            AddLecturerButton.Name = "AddLecturerButton";
            AddLecturerButton.Size = new Size(188, 22);
            AddLecturerButton.TabIndex = 10;
            AddLecturerButton.Text = "Add Lecturer";
            AddLecturerButton.TextAlign = ContentAlignment.MiddleLeft;
            AddLecturerButton.UseVisualStyleBackColor = true;
            AddLecturerButton.Click += AddLecturerButton_Click;
            // 
            // RemoveLecturerButton
            // 
            RemoveLecturerButton.Location = new Point(221, 532);
            RemoveLecturerButton.Margin = new Padding(4, 4, 4, 4);
            RemoveLecturerButton.Name = "RemoveLecturerButton";
            RemoveLecturerButton.Size = new Size(188, 22);
            RemoveLecturerButton.TabIndex = 11;
            RemoveLecturerButton.Text = "Remove Lecturer";
            RemoveLecturerButton.TextAlign = ContentAlignment.MiddleLeft;
            RemoveLecturerButton.UseVisualStyleBackColor = true;
            RemoveLecturerButton.Click += RemoveLecturerButton_Click;
            // 
            // DataGridViewMain
            // 
            DataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewMain.Location = new Point(221, 13);
            DataGridViewMain.Margin = new Padding(3, 2, 3, 2);
            DataGridViewMain.Name = "DataGridViewMain";
            DataGridViewMain.RowHeadersWidth = 51;
            DataGridViewMain.Size = new Size(800, 472);
            DataGridViewMain.TabIndex = 13;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 566);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
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
    }
}
