namespace WinFormsApp1
{
    internal class CourseAssessmentMark(Course course, List<int> marks)
    {
        public Course Course { get; set; } = course;
        private List<int> Marks = marks;
    }
}
