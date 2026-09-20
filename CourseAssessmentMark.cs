using System.Collections;
using static WinFormsApp1.CourseAssessmentMark;

namespace WinFormsApp1
{
    /// <summary>
    /// Represents a learner's given marks for a course.
    /// </summary>
    /// <param name="course"></param>
    /// <param name="marks"></param>
    internal class CourseAssessmentMark(Course course, List<int> marks)
    {
        public Course Course { get; set; } = course;
        private List<int> _marks = marks;

        /// <summary>
        /// Grade enum representing all possible grades.
        /// </summary>
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

        /// <summary>
        /// Get the equivalent grade of a mark.
        /// </summary>
        /// <param name="mark"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Convert Grade to string for formatting.
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static string GradeToString(Grade grade)
        {
            return grade switch
            {
                Grade.APlus => "A+",
                Grade.A => "A",
                Grade.AMinus => "A-",
                Grade.BPlus => "B+",
                Grade.B => "B",
                Grade.BMinus => "B-",
                Grade.CPlus => "C+",
                Grade.C => "C",
                Grade.CMinus => "C-",
                Grade.D => "D",
                Grade.E => "E",
                _ => "Unknown"
            };
        }

        /// <summary>
        /// Returns all marks.
        /// </summary>
        /// <returns></returns>
        public List<int> GetAllMarks()
        {
            return _marks;
        }

        /// <summary>
        /// Returns all grades.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Returns all highest marks.
        /// </summary>
        /// <returns></returns>
        public List<int> GetHighestMarks()
        {
            int maxValue = _marks.Max();
            return _marks.Where(n => n == maxValue).ToList();
        }

        /// <summary>
        /// Return all lowest passing marks.
        /// </summary>
        /// <returns></returns>
        public List<int> GetLowestMarks()
        {
            int minValue = _marks.Where(n => n >= 50).Min();

            return _marks.Where(n => n == minValue).ToList();
        }

        /// <summary>
        /// Return all fail marks.
        /// </summary>
        /// <returns></returns>
        public List<int> GetFailMarks()
        {
            List<int> failMarks = [];

            foreach (var mark in _marks)
            {
                if (mark <= 49)
                {
                    failMarks.Add(mark);
                }
            }

            return failMarks;
        }

        /// <summary>
        /// Return the average mark.
        /// </summary>
        /// <returns></returns>
        public double GetAverageMark()
        {
            return _marks.Average();
        }

        /// <summary>
        /// Return the average grade.
        /// </summary>
        /// <returns></returns>
        public Grade GetAverageGrade() 
        { 
            double averageMark = GetAverageMark(); 

            return GetGrade((int)Math.Round(averageMark)); 
        }

        public override string ToString()
        {
            return string.Join(",", _marks);
        }
    }
}
