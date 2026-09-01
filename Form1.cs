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

            List<Learner> Learner = [];
            List<Lecturer> Lecturer = [];

            DataHandler handler = new();

            try
            {
                handler.LoadLearners(courses);
            }
            catch (Exception ex)
            {
                ConsoleDebugger.Log(ex.Message, ConsoleDebugger.LogType.Error);
            }
        }
    }
}
