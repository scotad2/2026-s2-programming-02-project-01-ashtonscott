namespace WinFormsApp1
{
    /// <summary>
    /// Learner
    /// </summary>
    /// <param name="courseAssessmentMark"></param>
    internal class Learner(CourseAssessmentMark courseAssessmentMark) : Person
    {
        public CourseAssessmentMark CourseAssessmentMark { get; set; } = courseAssessmentMark;
    }
}
