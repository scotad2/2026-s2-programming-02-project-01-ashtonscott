namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private DataHandler _dataHandler = new();

        public void DisplayCourseDetails()
        {
            var courseData = _dataHandler.courses.Select(course => new
            {
                Institution = course.Department.Institution.Name,
                Department = course.Department.Name,
                Code = course.Code,
                Name = course.Name,
                Description = course.Description,
                Credits = course.Credits,
                Fees = course.Fees
            }).ToList();

            DataGridViewMain.DataSource = courseData;
        }

        public void DisplayAllMarks()
        {
            throw new NotImplementedException();
        }

        public void DisplayAllGrades()
        {
            throw new NotImplementedException();
        }

        public void DisplayHighestMarks()
        {
            throw new NotImplementedException();
        }

        public void DisplayLowestMarks()
        {
            throw new NotImplementedException();
        }

        public void DisplayFailMarks()
        {
            throw new NotImplementedException();
        }

        public void DisplayAverageMarks()
        {
            throw new NotImplementedException();
        }

        public void DisplayLecturerDetails()
        {
            throw new NotImplementedException();
        }

        public Form1()
        {
            InitializeComponent();

            try
            {
                _dataHandler.LoadFiles();
            }
            catch (Exception ex)
            {
                ConsoleDebugger.Log(ex.Message, ConsoleDebugger.LogType.Error);
            }

            foreach (var learner in _dataHandler.learners)
            {
                ConsoleDebugger.Log($"\n{learner.ToString()}", ConsoleDebugger.LogType.Info);
                Console.WriteLine();
            }

            foreach (var lecturer in _dataHandler.lecturers)
            {
                ConsoleDebugger.Log($"\n{lecturer.ToString()}", ConsoleDebugger.LogType.Info);
                Console.WriteLine();
            }
        }

        private void DisplayCourseDetailsButton_Click(object sender, EventArgs e)
        {
            ConsoleDebugger.Log("'Display Course Details' selected.", ConsoleDebugger.LogType.Event);
            DisplayCourseDetails();
        }

        private void DisplayAllMarksButton_Click(object sender, EventArgs e)
        {
            ConsoleDebugger.Log("'Display All Marks' selected.", ConsoleDebugger.LogType.Event);
        }

        private void DisplayAllGradesButton_Click(object sender, EventArgs e)
        {
            ConsoleDebugger.Log("'Display All Grades' selected.", ConsoleDebugger.LogType.Event);
        }

        private void DisplayHighestMarksButton_Click(object sender, EventArgs e)
        {
            ConsoleDebugger.Log("'Display Highest Marks' selected.", ConsoleDebugger.LogType.Event);
        }

        private void DisplayLowestMarksButton_Click(object sender, EventArgs e)
        {
            ConsoleDebugger.Log("'Display Lowest Marks' selected.", ConsoleDebugger.LogType.Event);
        }

        private void DisplayFailMarksButton_Click(object sender, EventArgs e)
        {
            ConsoleDebugger.Log("'Display Fail Marks' selected.", ConsoleDebugger.LogType.Event);
        }

        private void DisplayAverageMarksButton_Click(object sender, EventArgs e)
        {
            ConsoleDebugger.Log("'Display Average Marks' selected.", ConsoleDebugger.LogType.Event);
        }

        private void DisplayAverageGradesButton_Click(object sender, EventArgs e)
        {
            ConsoleDebugger.Log("'Display Average Grades' selected.", ConsoleDebugger.LogType.Event);
        }

        private void DisplayLecturerDetailsButton_Click(object sender, EventArgs e)
        {
            ConsoleDebugger.Log("'Display Lecturer Details' selected.", ConsoleDebugger.LogType.Event);
        }

        private void AddLearnerButton_Click(object sender, EventArgs e)
        {
            ConsoleDebugger.Log("'Add Learner' selected.", ConsoleDebugger.LogType.Event);
        }

        private void AddLecturerButton_Click(object sender, EventArgs e)
        {
            ConsoleDebugger.Log("'Add Lecturer' selected.", ConsoleDebugger.LogType.Event);
        }

        private void RemoveLecturerButton_Click(object sender, EventArgs e)
        {
            ConsoleDebugger.Log("'Remove Lecturer' selected.", ConsoleDebugger.LogType.Event);
        }

        private void CustomQueriesButton_Click(object sender, EventArgs e)
        {
            ConsoleDebugger.Log("'Custom Queries' selected.", ConsoleDebugger.LogType.Event);
        }
    }
}
