namespace WinFormsApp1
{
    /// <summary>
    /// Seeds the program with test data.
    /// </summary>
    static internal class Seeder
    {
        private static List<Institution> Institutions = [];
        private static List<Department> Departments = [];
        private static List<Course> Courses = [];

        public static List<Institution> SeedInstitution()
        {
            Institutions.Add(new Institution(
                "Otago Polytechnic",
                "Otago",
                "New Zealand"));

            Institutions.Add(new Institution(
                "University of Otago",
                "Otago",
                "New Zealand"));

            Institutions.Add(new Institution(
                "University of Canterbury",
                "Canterbury",
                "New Zealand"));

            return Institutions;
        }

        public static List<Department> SeedDepartment()
        {
            Departments.Add(new Department(
                Institutions[0],
                "Information Technology"));

            Departments.Add(new Department(
                Institutions[1],
                "Computer Science"));

            Departments.Add(new Department(
                Institutions[2],
                "Engineering"));

            return Departments;
        }

        public static List<Course> SeedCourse()
        {
            // Information Technology
            Courses.Add(new Course(
                Departments[0],
                101,
                "Introduction to Programming",
                "An introduction to programming.",
                15,
                750));

            Courses.Add(new Course(
                Departments[0],
                102,
                "Web Development",
                "An introduction to web development.",
                15,
                800));

            // Computer Science
            Courses.Add(new Course(
                Departments[1],
                201,
                "Database Development",
                "An introduction to databases and SQL.",
                15,
                850));

            Courses.Add(new Course(
                Departments[1],
                202,
                "Data Structures",
                "An introduction to data structures and algorithms.",
                15,
                900));

            // Engineering
            Courses.Add(new Course(
                Departments[2],
                301,
                "Engineering Fundamentals",
                "An introduction to engineering principles.",
                15,
                900));

            Courses.Add(new Course(
                Departments[2],
                302,
                "Engineering Design",
                "An introduction to engineering design.",
                15,
                950));

            return Courses;
        }
    }
}