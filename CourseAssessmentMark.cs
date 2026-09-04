namespace WinFormsApp1
{
    internal class CourseAssessmentMark(Course course, List<int> marks)
    {
        public Course Course { get; set; } = course;
        private List<int> _marks = marks;

        public enum Grade
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

        private Grade GetGrade(int mark)
        {
            switch (mark)
            {
                case >= 90:
                    return Grade.APlus;

                case >= 85:
                    return Grade.A;

                case >= 80:
                    return Grade.AMinus;

                case >= 75:
                    return Grade.BPlus;

                case >= 70:
                    return Grade.B;

                case >= 65:
                    return Grade.BMinus;

                case >= 60:
                    return Grade.CPlus;

                case >= 55:
                    return Grade.C;

                case >= 50:
                    return Grade.CMinus;

                case >= 40:
                    return Grade.D;

                default:
                    return Grade.E;
            }
        }

        public List<int> GetAllMarks()
        {
            return _marks;
        }

        public List<Grade> GetAllGrades()
        {
            List<Grade> grades = [];

            foreach (var mark in _marks)
            {
                Grade grade = GetGrade(mark);
                grades.Add(grade);
            }

            return grades;
        }
    }
}
