using static WinFormsApp1.Lecturer;

namespace WinFormsApp1
{
    /// <summary>
    /// Lecturer
    /// </summary>
    /// <param name="position"></param>
    /// <param name="salary"></param>
    /// <param name="course"></param>
    internal class Lecturer : Person
    {
        private EPosition _position;
        private ESalary _salary;

        private int _courseIndex;

        public Lecturer(int id, string firstName, string lastName, EPosition ePosition, ESalary eSalary, int courseIndex)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            _position = ePosition;
            _salary = eSalary;
            _courseIndex = courseIndex;
        }

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

        public override string ToString()
        {
            return $"""
                ID: {Id}
                Firstname: {FirstName}
                Lastname: {LastName}
                """;
        }

        //public EPosition Position { get; set; } = position;
        //public ESalary Salary { get; set; } = salary;
        //public Course Course { get; set; } = course;
    }
}
