using Microsoft.VisualBasic.Logging;

namespace WinFormsApp1
{
    internal class DataHandler
    {
        public List<Learner> Learner = [];
        public List<Lecturer> Lecturer = [];

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


        private const string DataPath = @"../../../data/";

        public void LoadLearners(List<Course> courses)
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
                int id = int.Parse(fields[0]); // Id
                string firstName = fields[1]; // First Name
                string lastName = fields[2]; // Last Name
                int courseIndex = int.Parse(fields[3]); // Course Index

                List<int> marks = [];

                for (int i = 4; i < fields.Length; i++)
                {
                    marks.Add(int.Parse(fields[i]));
                }

                CourseAssessmentMark courseAssessmentMark = new(courses[courseIndex], marks);
            }
        }
    }
}
