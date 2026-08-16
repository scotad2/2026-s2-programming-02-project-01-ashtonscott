namespace WinFormsApp1
{
    /// <summary>
    /// Lecturer
    /// </summary>
    /// <param name="position"></param>
    /// <param name="salary"></param>
    /// <param name="course"></param>
    internal class Lecturer(Lecturer.EPosition position, Lecturer.ESalary salary, Course course) : Person
    {
        public enum EPosition
        {
            Lecturer = 0,
            Senior_Lecturer = 1,
            Principal_Lecturer = 2,
            Associate_Professor = 3,
            Professor = 4
        }

        public enum ESalary
        {
            Lecturer_Salary = 85000,
            Senior_Lecturer_Salary = 100000,
            Principal_Lecturer_Salary = 115000,
            Associate_Professor_Salary = 130000,
            Professor_Salary = 145000
        }

        public EPosition Position { get; set; } = position;
        public ESalary Salary { get; set; } = salary;
        public Course Course { get; set; } = course;
    }
}
