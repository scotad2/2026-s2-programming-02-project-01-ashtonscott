namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataHandler dataHandler = new();

            try
            {
                dataHandler.LoadFiles();
            }
            catch (Exception ex)
            {
                ConsoleDebugger.Log(ex.Message, ConsoleDebugger.LogType.Error);
            }

            foreach (var learner in dataHandler.learners)
            {
                ConsoleDebugger.Log($"\n{learner.ToString()}", ConsoleDebugger.LogType.Info);
                Console.WriteLine();
            }

            foreach (var lecturer in dataHandler.lecturers)
            {
                ConsoleDebugger.Log($"\n{lecturer.ToString()}", ConsoleDebugger.LogType.Info);
                Console.WriteLine();
            }
        }

        private void DisplayCourseDetailsButton_Click(object sender, EventArgs e)
        {
            ConsoleDebugger.Log("'Display Course Details' selected.", ConsoleDebugger.LogType.Event);
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
