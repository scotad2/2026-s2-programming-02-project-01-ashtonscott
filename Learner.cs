namespace WinFormsApp1
{
    /// <summary>
    /// Learner
    /// </summary>
    /// <param name="courseAssessmentMark"></param>
    internal class Learner : Person
    {
        public CourseAssessmentMark CourseAssessmentMark { get; set; }

        public Learner(int id, string firstName, string lastName, CourseAssessmentMark courseAssessmentMark)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CourseAssessmentMark = courseAssessmentMark;

            ConsoleDebugger.Log($"Added '{firstName} {lastName}'");
        }
    }
}
