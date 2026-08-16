namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Seeders
            ConsoleDebugger.Log("Seeding data.", ConsoleDebugger.LogType.Info);
            List<Institution> institutions = Seeder.SeedInstitution();
            List<Department> departments = Seeder.SeedDepartment();
            List<Course> courses = Seeder.SeedCourse();
        }
    }
}
