namespace WinFormsApp1
{
    /// <summary>
    /// Represents a lecturer.
    /// </summary>
    internal class Lecturer : Person
    {
        public enum EPosition
        {
            Lecturer,
            SeniorLecturer,
            PrincipalLecturer,
            AssociateProfessor,
            Professor
        }

        public enum ESalary
        {
            LecturerSalary = 85000,
            SeniorLecturerSalary = 100000,
            PrincipalLecturerSalary = 115000,
            AssociateProfessorSalary = 130000,
            ProfessorSalary = 145000
        }

        public EPosition Position { get; }
        public ESalary Salary { get; }
        public int CourseIndex { get; }

        public Lecturer(
            int id,
            string firstName,
            string lastName,
            EPosition position,
            ESalary salary,
            int courseIndex)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            Salary = salary;
            CourseIndex = courseIndex;

            ConsoleDebugger.Log($"Added Lecturer '{firstName} {lastName}'");
        }

        public override string ToString()
        {
            return $"""
            Type: Lecturer
            ID: {Id}
            Firstname: {FirstName}
            Lastname: {LastName}
            Position: {Position}
            Salary: {Salary}
            Course Index: {CourseIndex}
            """;
        }
    }
}