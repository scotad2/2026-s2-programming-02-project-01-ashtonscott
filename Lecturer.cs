namespace WinFormsApp1
{
    /// <summary>
    /// Represents a lecturer.
    /// </summary>
    internal class Lecturer : Person
    {
        /// <summary>
        /// Lecturer position
        /// </summary>
        public enum EPosition
        {
            Lecturer,
            SeniorLecturer,
            PrincipalLecturer,
            AssociateProfessor,
            Professor
        }

        /// <summary>
        /// Lecturer salary
        /// </summary>
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

        /// <summary>
        /// Create a new Lecturer object.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="position"></param>
        /// <param name="salary"></param>
        /// <param name="courseIndex"></param>
        public Lecturer(int id, string firstName, string lastName, EPosition position, ESalary salary, int courseIndex)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            Salary = salary;
            CourseIndex = courseIndex;
        }

        /// <summary>
        /// Convert EPosition to string for formatting.
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public static string PositionToString(EPosition position)
        {
            return position switch
            {
                EPosition.Lecturer => "Lecturer",
                EPosition.SeniorLecturer => "Senior Lecturer",
                EPosition.PrincipalLecturer => "Principal Lecturer",
                EPosition.AssociateProfessor => "Associate Professor",
                EPosition.Professor => "Professor",
                _ => "Unknown"
            };
        }

        /// <summary>
        /// Get the lecturer ESalary from EPosition
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static ESalary GetSalary(EPosition position)
        {
            return position switch
            {
                EPosition.Lecturer => ESalary.LecturerSalary,
                EPosition.SeniorLecturer => ESalary.SeniorLecturerSalary,
                EPosition.PrincipalLecturer => ESalary.PrincipalLecturerSalary,
                EPosition.AssociateProfessor => ESalary.AssociateProfessorSalary,
                EPosition.Professor => ESalary.ProfessorSalary,
                _ => throw new ArgumentException("Invalid position")
            };
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