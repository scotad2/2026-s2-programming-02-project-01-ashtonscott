using static WinFormsApp1.Lecturer;

namespace WinFormsApp1
{
    public partial class MainForm : Form
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
            var markData = _dataHandler.learners.Select(learner => new
            {
                ID = learner.Id,
                FirstName = learner.FirstName,
                LastName = learner.LastName,
                Course = learner.CourseAssessmentMark.Course.Name,
                Marks = string.Join(", ", learner.CourseAssessmentMark.GetAllMarks())
            }).ToList();

            DataGridViewMain.DataSource = markData;
        }

        public void DisplayAllGrades()
        {
            var gradeData = _dataHandler.learners.Select(learner =>
            {
                var grades = learner.CourseAssessmentMark.GetAllGrades();

                return new
                {
                    ID = learner.Id,
                    FirstName = learner.FirstName,
                    LastName = learner.LastName,
                    Course = learner.CourseAssessmentMark.Course.Name,
                    Grades = string.Join(", ", grades.Select(CourseAssessmentMark.GradeToString))
                };
            }).ToList();

            DataGridViewMain.DataSource = gradeData;
        }

        public void DisplayHighestMarks()
        {
            var highestMarkData = _dataHandler.learners.Select(learner => new
            {
                ID = learner.Id,
                FirstName = learner.FirstName,
                LastName = learner.LastName,
                Course = learner.CourseAssessmentMark.Course.Name,
                Marks = string.Join(", ", learner.CourseAssessmentMark.GetHighestMarks())
            }).ToList();

            DataGridViewMain.DataSource = highestMarkData;
        }

        public void DisplayLowestMarks()
        {
            var lowestMarkData = _dataHandler.learners.Select(learner => new
            {
                ID = learner.Id,
                FirstName = learner.FirstName,
                LastName = learner.LastName,
                Course = learner.CourseAssessmentMark.Course.Name,
                Marks = string.Join(", ", learner.CourseAssessmentMark.GetLowestMarks())
            }).ToList();

            DataGridViewMain.DataSource = lowestMarkData;
        }

        public void DisplayFailMarks()
        {
            var failMarkData = _dataHandler.learners.Select(learner => new
            {
                ID = learner.Id,
                FirstName = learner.FirstName,
                LastName = learner.LastName,
                Course = learner.CourseAssessmentMark.Course.Name,
                Marks = string.Join(", ", learner.CourseAssessmentMark.GetFailMarks())
            }).ToList();

            DataGridViewMain.DataSource = failMarkData;
        }

        public void DisplayAverageMarks()
        {
            var averageMarkData = _dataHandler.learners.Select(learner => new
            {
                ID = learner.Id,
                FirstName = learner.FirstName,
                LastName = learner.LastName,
                Course = learner.CourseAssessmentMark.Course.Name,
                Marks = string.Join(", ", learner.CourseAssessmentMark.GetAverageMark())
            }).ToList();

            DataGridViewMain.DataSource = averageMarkData;
        }

        public void DisplayAverageGrades()
        {
            var averageGradeData = _dataHandler.learners.Select(learner => new
            {
                ID = learner.Id,
                FirstName = learner.FirstName,
                LastName = learner.LastName,
                Course = learner.CourseAssessmentMark.Course.Name,
                AverageGrade = CourseAssessmentMark.GradeToString(learner.CourseAssessmentMark.GetAverageGrade())
            }).ToList();

            DataGridViewMain.DataSource = averageGradeData;
        }

        public void DisplayLecturerDetails()
        {
            var lecturerData = _dataHandler.lecturers.Select(lecturer => new
            {
                ID = lecturer.Id,
                FirstName = lecturer.FirstName,
                LastName = lecturer.LastName,
                Position = Lecturer.PositionToString(lecturer.Position),
                Salary = $"${(int)lecturer.Salary}", // Cast ESalary as an int
                Course = _dataHandler.courses[lecturer.CourseIndex].Name
            }).ToList();

            DataGridViewMain.DataSource = lecturerData;
        }

        public MainForm()
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

            DisplayAllMarks();
        }

        private void DisplayAllGradesButton_Click(object sender, EventArgs e)
        {
            ConsoleDebugger.Log("'Display All Grades' selected.", ConsoleDebugger.LogType.Event);

            DisplayAllGrades();
        }

        private void DisplayHighestMarksButton_Click(object sender, EventArgs e)
        {
            ConsoleDebugger.Log("'Display Highest Marks' selected.", ConsoleDebugger.LogType.Event);

            DisplayHighestMarks();
        }

        private void DisplayLowestMarksButton_Click(object sender, EventArgs e)
        {
            ConsoleDebugger.Log("'Display Lowest Marks' selected.", ConsoleDebugger.LogType.Event);

            DisplayLowestMarks();
        }

        private void DisplayFailMarksButton_Click(object sender, EventArgs e)
        {
            ConsoleDebugger.Log("'Display Fail Marks' selected.", ConsoleDebugger.LogType.Event);

            DisplayFailMarks();
        }

        private void DisplayAverageMarksButton_Click(object sender, EventArgs e)
        {
            ConsoleDebugger.Log("'Display Average Marks' selected.", ConsoleDebugger.LogType.Event);

            DisplayAverageMarks();
        }

        private void DisplayAverageGradesButton_Click(object sender, EventArgs e)
        {
            ConsoleDebugger.Log("'Display Average Grades' selected.", ConsoleDebugger.LogType.Event);

            DisplayAverageGrades();
        }

        private void DisplayLecturerDetailsButton_Click(object sender, EventArgs e)
        {
            ConsoleDebugger.Log("'Display Lecturer Details' selected.", ConsoleDebugger.LogType.Event);

            DisplayLecturerDetails();
        }

        private void AddLearnerButton_Click(object sender, EventArgs e)
        {
            ConsoleDebugger.Log("'Add Learner' selected.", ConsoleDebugger.LogType.Event);

            AddLearnerForm form = new(_dataHandler);

            form.ShowDialog();
        }

        private void AddLecturerButton_Click(object sender, EventArgs e)
        {
            ConsoleDebugger.Log("'Add Lecturer' selected.", ConsoleDebugger.LogType.Event);

            AddLecturerForm form = new(_dataHandler);

            form.ShowDialog();
        }

        private void RemoveLecturerButton_Click(object sender, EventArgs e)
        {
            ConsoleDebugger.Log("'Remove Lecturer' selected.", ConsoleDebugger.LogType.Event);
        }

        private void RemoveLearnerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
