// BELOW IS A REFERENCE AS TO WHAT THE DATA SHOULD LOOK LIKE.

// MAKE SURE IT LOOKS LIKE THIS.

// learners.txt
// ┌────┬─────────────┬────────────┬───────────────┬───────────────────┐
// │ ID │  First Name │  Last Name │  Course Index │  Assessment Marks │
// ├────┼─────────────┼────────────┼───────────────┼───────────────────┤
// │  1 │ Alex        │ Walker     │             0 │    90 95 85 15  5 │
// │  2 │ Lucy        │ Taylor     │             0 │    50 40 50 70 60 │
// │  3 │ Ethan       │ Moore      │             1 │    60 65 80 85 60 │
// │  4 │ Chloe       │ Adams      │             1 │    20 30 40 65 75 │
// │  5 │ Noah        │ Baker      │             2 │    80 88 90 50 15 │
// └────┴─────────────┴────────────┴───────────────┴───────────────────┘

// lecturers.txt
// ┌────┬─────────────┬────────────┬────────────┬──────────┬───────────────┐
// │ ID │  First Name │  Last Name │  EPosition │  ESalary │  Course Index │
// ├────┼─────────────┼────────────┼────────────┼──────────┼───────────────┤
// │  1 │ Michael     │ Brown      │          1 │   100000 │             0 │
// │  2 │ Sophia      │ Green      │          4 │   145000 │             1 │
// │  3 │ Ethan       │ White      │          0 │    85000 │             2 │
// │  4 │ Emma        │ Clark      │          1 │   100000 │             0 │
// │  5 │ Liam        │ Harris     │          2 │   115000 │             1 │
// └────┴─────────────┴────────────┴────────────┴──────────┴───────────────┘

using static WinFormsApp1.Lecturer;

namespace WinFormsApp1
{
    /// <summary>
    /// Handles all persistent program data.
    /// </summary>
    internal class DataHandler
    {
        public List<Institution> institutions = Seeder.SeedInstitution();
        public List<Department> departments = Seeder.SeedDepartment();
        public List<Course> courses = Seeder.SeedCourse();

        public List<Learner> learners = [];
        public List<Lecturer> lecturers = [];

        private const string DataPath = @"../../../data/";

        /// <summary>
        /// Loads the learner.txt file data
        /// </summary>
        /// <exception cref="FileNotFoundException"></exception>
        private void LoadLearnersFile()
        {
            // Check if the file exists
            if (!File.Exists(DataPath + "learners.txt"))
            {
                throw new FileNotFoundException();
            }

            string[] lines = File.ReadAllLines(DataPath + "learners.txt");

            foreach (string line in lines)
            {
                // Seperate into fields
                string[] fields = line.Split(",");

                // Learner fields
                int id = int.Parse(fields[0]);          // Id
                string firstName = fields[1];           // First Name
                string lastName = fields[2];            // Last Name
                int courseIndex = int.Parse(fields[3]); // Course Index

                List<int> marks = [];

                // Add marks to above list
                for (int i = 4; i < fields.Length; i++)
                {
                    marks.Add(int.Parse(fields[i]));
                }

                CourseAssessmentMark courseAssessmentMark = new(courses[courseIndex], marks);

                // Add Learners to the Learner list
                learners.Add(new(id, firstName, lastName, courseAssessmentMark));
            }
        }

        /// <summary>
        /// Loads the lecturers.txt file data
        /// </summary>
        /// <exception cref="FileNotFoundException"></exception>
        private void LoadLecturersFile()
        {
            // Check if the file exists
            if (!File.Exists(DataPath + "lecturers.txt"))
            {
                throw new FileNotFoundException();
            }

            string[] lines = File.ReadAllLines(DataPath + "lecturers.txt");

            foreach (string line in lines)
            {
                // Seperate into fields
                string[] fields = line.Split(",");

                // Lecturer fields
                int id = int.Parse(fields[0]);                  // Id
                string firstName = fields[1];                   // First Name
                string lastName = fields[2];                    // Last Name
                Lecturer.EPosition position = (Lecturer.EPosition)int.Parse(fields[3]); // EPosition
                Lecturer.ESalary salary = (Lecturer.ESalary)int.Parse(fields[4]);       // ESalary
                int courseIndex = int.Parse(fields[5]);         // Course Index

                // Add Lecturer to the Lecturer list
                lecturers.Add(new(id, firstName, lastName, position, salary, courseIndex));
            }
        }

        /// <summary>
        /// Load all persistent data saved in files.
        /// </summary>
        public void LoadFiles()
        {
            // This method might seem a little redundant but
            // this is just so I only need to call only one method
            // from MainForm.cs

            // ./data/learners.txt
            LoadLearnersFile();

            // ./data/lecturers.txt
            LoadLecturersFile();
        }

        /// <summary>
        /// Add a Learner to learners.txt
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="courseIndex"></param>
        /// <param name="marks"></param>
        public void AddLearner(string firstName, string lastName, int courseIndex, List<int> marks)
        {
            int id = learners.Count + 1;

            // Create the Learners Course Assessment Marks
            CourseAssessmentMark courseAssessmentMark = new(courses[courseIndex], marks);

            // Add Learner to the Learner list
            learners.Add(new(id, firstName, lastName, courseAssessmentMark));

            // Create the data entry
            string dataEntry = $"{id},{firstName},{lastName},{courses.IndexOf(courseAssessmentMark.Course)},{string.Join(",", courseAssessmentMark.GetAllMarks())}";

            // Append the data entry to learners.txt
            File.AppendAllText(DataPath + "learners.txt", "\n" + dataEntry);
        }

        /// <summary>
        /// Add a Lecturer to lecturers.txt
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="position"></param>
        /// <param name="salary"></param>
        /// <param name="courseIndex"></param>
        public void AddLecturer(string firstName, string lastName, EPosition position, ESalary salary, int courseIndex)
        {
            int id = lecturers.Count + 1;

            // Add Lecturer to the Lecturer list
            lecturers.Add(new(id, firstName, lastName, position, salary, courseIndex));

            // Create the data entry
            string dataEntry = $"{id},{firstName},{lastName},{(int)position},{(int)salary},{courseIndex}";

            // Append the data entry to lecturers.txt
            File.AppendAllText(DataPath + "lecturers.txt", "\n" + dataEntry );
        }

        /// <summary>
        /// Remove a Lecturer from lecturers.txt
        /// </summary>
        /// <param name="lecturer"></param>
        public void RemoveLecturer(Lecturer lecturer)
        {
            // Remove the Lecturer from the list
            lecturers.Remove(lecturer);

            List<string> dataEntries = [];

            // Rebuild the lecturers.txt file

            // This ends up being really simple but I don't know if it's the
            // best way to go about this sort of thing.

            foreach (Lecturer l in lecturers)
            {
                dataEntries.Add($"{l.Id},{l.FirstName},{l.LastName},{(int)l.Position},{(int)l.Salary},{l.CourseIndex}");
            }

            // Overwrite the data entries to lecturers.txt
            File.WriteAllLines(DataPath + "lecturers.txt", dataEntries);
        }
    }
}
