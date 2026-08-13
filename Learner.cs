using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
