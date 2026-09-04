namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Seeders
            ConsoleDebugger.Log("Loading institute, department and course data.", ConsoleDebugger.LogType.Info);
            List<Institution> institutions = Seeder.SeedInstitution();
            List<Department> departments = Seeder.SeedDepartment();
            List<Course> courses = Seeder.SeedCourse();

            DataHandler dataHandler = new();

            try
            {
                dataHandler.LoadLearners(courses);

                foreach (var learner in dataHandler.Learners)
                {
                    foreach(var grade in learner.CourseAssessmentMark.GetAllGrades())
                    {
                        Console.WriteLine(grade);
                    }
                    Console.WriteLine("");
                }
            }
            catch (Exception ex)
            {
                ConsoleDebugger.Log(ex.Message, ConsoleDebugger.LogType.Error);
            }
        }
    }
}
