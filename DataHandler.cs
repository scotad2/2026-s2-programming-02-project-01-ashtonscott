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
            if (!File.Exists(DataPath + "learners.txt"))
            {
                throw new FileNotFoundException();
            }

            string[] lines = File.ReadAllLines(DataPath + "learners.txt");
            foreach (string line in lines)
            {
                string[] fields = line.Split(",");

                // Learner fields
                int id = int.Parse(fields[0]);          // Id
                string firstName = fields[1];           // First Name
                string lastName = fields[2];            // Last Name
                int courseIndex = int.Parse(fields[3]); // Course Index

                List<int> marks = [];

                // Marks
                for (int i = 4; i < fields.Length; i++)
                {
                    marks.Add(int.Parse(fields[i]));
                }

                CourseAssessmentMark courseAssessmentMark = new(courses[courseIndex], marks);

                // Add Learners to the Learner list
                AddLearner(id, firstName, lastName, courseAssessmentMark);
            }
        }

        /// <summary>
        /// Loads the lecturer.txt file data
        /// </summary>
        /// <exception cref="FileNotFoundException"></exception>
        private void LoadLecturersFile()
        {
            string filePath = Path.Combine(DataPath, "lecturers.txt");

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException();
            }

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
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
        /// Load all persistent data saved in files
        /// </summary>
        public void LoadFiles()
        {
            LoadLearnersFile(); // ./data/learners.txt
            LoadLecturersFile(); // ./data/lecturers.txt
        }

        public void AddLearner (int id,
                                string firstName,
                                string lastName,
                                CourseAssessmentMark courseAssessmentMark)
        {
            learners.Add(new(id, firstName, lastName, courseAssessmentMark));
        }

        public void AddLecturer(int id,
                                string firstName,
                                string lastName,
                                EPosition position,
                                ESalary salary,
                                int courseIndex)
        {
            lecturers.Add(new(id, firstName, lastName, position, salary, courseIndex));
        }
    }
}
