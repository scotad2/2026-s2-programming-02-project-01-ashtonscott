using static WinFormsApp1.Lecturer;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private DataHandler _dataHandler = new();

        /// <summary>
        /// Display all course details to the main data grid.
        /// </summary>
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

        /// <summary>
        /// Display all marks to the main data grid.
        /// </summary>
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

        /// <summary>
        /// Display all grades to the main data grid.
        /// </summary>
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

        /// <summary>
        /// Display highest marks to the main data grid.
        /// </summary>
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

        /// <summary>
        /// Display lowest marks to the main data grid.
        /// </summary>
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

        /// <summary>
        /// Display fail marks to the main data grid.
        /// </summary>
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

        /// <summary>
        /// Display average marks to the main data grid.
        /// </summary>
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

        /// <summary>
        /// Display average grades to the main data grid.
        /// </summary>
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

        /// <summary>
        /// Displays lecturer details to the main data grid.
        /// </summary>
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

        /// <summary>
        /// Search for a person by Firstname, Lastname or ID
        /// </summary>
        public void PersonSearch()
        {
            // Fields

            // 0 = Firstname
            // 1 = Lastname
            // 2 = ID

            int searchField = PersonComboBox.SelectedIndex;

            // Check if a search field hasn't been selected
            if (searchField == -1)
            {
                MessageBox.Show($"You need to select a search field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string searchTerm = PersonSearchTerm.Text;

            List<Person> results = [];

            // Search by given field

            if (searchField == 0) // Firstname
            {
                results.AddRange(_dataHandler.learners.Where(l => l.FirstName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)));
                results.AddRange(_dataHandler.lecturers.Where(l => l.FirstName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)));
            }
            else if (searchField == 1) // Lastname
            {
                results.AddRange(_dataHandler.learners.Where(l => l.LastName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)));
                results.AddRange(_dataHandler.lecturers.Where(l => l.LastName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)));
            }
            else if (searchField == 2) // ID
            {
                if (int.TryParse(searchTerm, out int id))
                {
                    results.AddRange(_dataHandler.learners.Where(l => l.Id == id));
                    results.AddRange(_dataHandler.lecturers.Where(l => l.Id == id));
                }
                else
                {
                    MessageBox.Show($"'{searchTerm}' is not a valid search term for ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Check if no results were matched
            if (results.Count == 0)
            {
                MessageBox.Show($"No matching people were found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var displayResults = results.Select(person => new
            {
                // Ternary operator:
                // If person type is 'Learner', set "Learner" else set "Lecturer"
                Type = person is Learner ? "Learner" : "Lecturer",
                ID = person.Id,
                FirstName = person.FirstName,
                LastName = person.LastName
            }).ToList();

            DataGridViewMain.DataSource = displayResults;
        }

        public void FilterMarksByRange()
        {
            // Check and parse the marks
            if (!int.TryParse(MinValue.Text, out int minMark) || !int.TryParse(MaxValue.Text, out int maxMark))
            {
                MessageBox.Show("Please enter valid minimum and maximum marks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check that the marks are within the correct range
            if (minMark < 0 || maxMark < 0 || minMark > 100 || maxMark > 100)
            {
                MessageBox.Show("Marks must be between 0 and 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check that the minimum mark is not greater than the maximum mark
            if (minMark > maxMark)
            {
                // One must never assume the user knows what they are doing
                MessageBox.Show("The minimum mark cannot be greater than the maximum mark.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Learner> results = [];

            results.AddRange(_dataHandler.learners.Where(l =>l.CourseAssessmentMark.GetAllMarks().Any(mark => mark >= minMark && mark <= maxMark)));

            // Check if no results were matched
            if (results.Count == 0)
            {
                MessageBox.Show($"No matching learners were found with marks between '{minMark}' and '{maxMark}'.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var displayResults = results.Select(learner => new
            {
                ID = learner.Id,
                FirstName = learner.FirstName,
                LastName = learner.LastName,
                Course = learner.CourseAssessmentMark.Course.Name,
                Marks = string.Join(", ", learner.CourseAssessmentMark.GetAllMarks())
            }).ToList();

            DataGridViewMain.DataSource = displayResults;
        }

        public void CourseSearch()
        {
            // Fields

            // 0 = Course name
            // 1 = Code

            int searchField = CourseComboBox.SelectedIndex;

            // Check if a search field hasn't been selected
            if (searchField == -1)
            {
                MessageBox.Show($"You need to select a search field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string searchTerm = CourseSearchTerm.Text;

            List<Course> results = [];

            // Search by given field

            if (searchField == 0) // Course name
            {
                results.AddRange(_dataHandler.courses.Where(c => c.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)));
            }
            else if (searchField == 1) // Code
            {
                if (int.TryParse(searchTerm, out int code))
                {
                    results.AddRange(_dataHandler.courses.Where(c => c.Code == code));
                }
                else
                {
                    MessageBox.Show($"'{searchTerm}' is not a valid search term for Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Check if no results were matched
            if (results.Count == 0)
            {
                MessageBox.Show($"No matching courses were found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var displayResults = results.Select(course => new
            {
                Institution = course.Department.Institution.Name,
                Department = course.Department.Name,
                Code = course.Code,
                Name = course.Name,
                Description = course.Description,
                Credits = course.Credits,
                Fees = course.Fees
            }).ToList();

            DataGridViewMain.DataSource = displayResults;
        }

        public void CalculateAverageSalary()
        {
            double averageSalary = _dataHandler.lecturers.Average(l => (int)l.Salary);

            MessageBox.Show($"Average Salary: {averageSalary:C0}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public MainForm()
        {
            InitializeComponent();

            try
            {
                // Load all persistent data saved in files.
                _dataHandler.LoadFiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayCourseDetailsButton_Click(object sender, EventArgs e)
        {
            DisplayCourseDetails();
        }

        private void DisplayAllMarksButton_Click(object sender, EventArgs e)
        {
            DisplayAllMarks();
        }

        private void DisplayAllGradesButton_Click(object sender, EventArgs e)
        {
            DisplayAllGrades();
        }

        private void DisplayHighestMarksButton_Click(object sender, EventArgs e)
        {
            DisplayHighestMarks();
        }

        private void DisplayLowestMarksButton_Click(object sender, EventArgs e)
        {
            DisplayLowestMarks();
        }

        private void DisplayFailMarksButton_Click(object sender, EventArgs e)
        {
            DisplayFailMarks();
        }

        private void DisplayAverageMarksButton_Click(object sender, EventArgs e)
        {
            DisplayAverageMarks();
        }

        private void DisplayAverageGradesButton_Click(object sender, EventArgs e)
        {
            DisplayAverageGrades();
        }

        private void DisplayLecturerDetailsButton_Click(object sender, EventArgs e)
        {
            DisplayLecturerDetails();
        }

        private void AddLearnerButton_Click(object sender, EventArgs e)
        {
            AddLearnerForm form = new(_dataHandler);

            form.ShowDialog();
        }

        private void AddLecturerButton_Click(object sender, EventArgs e)
        {
            AddLecturerForm form = new(_dataHandler);

            form.ShowDialog();
        }

        private void RemoveLecturerButton_Click(object sender, EventArgs e)
        {
            RemoveLecturerForm form = new(_dataHandler);

            form.ShowDialog();
        }

        private void PersonSearchButton_Click(object sender, EventArgs e)
        {
            PersonSearch();
        }

        private void CourseSearchButton_Click(object sender, EventArgs e)
        {
            CourseSearch();
        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            int statisticsOption = StatisticsComboBox.SelectedIndex;

            // Check if the user hasn't selected anything
            if (statisticsOption == -1)
            {
                MessageBox.Show("You have not selected an item to compute.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (statisticsOption == 0)
            {
                CalculateAverageSalary();
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            FilterMarksByRange();
        }
    }
}
