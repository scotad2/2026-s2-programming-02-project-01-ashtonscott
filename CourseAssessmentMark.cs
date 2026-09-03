namespace WinFormsApp1
{
    internal class CourseAssessmentMark(Course course, List<int> marks)
    {
        public Course Course { get; set; } = course;
        private List<int> _marks = marks;

        private enum Grade
        {
            APlus,
            A,
            AMinus,
            BPlus,
            B,
            BMinus,
            CPlus,
            C,
            CMinus,
            D,
            E,
        }

        public List<int> GetAllMarks()
        {
            return _marks;
        }
    }
}
