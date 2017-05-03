using Academy.Models.Utils.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Enums;

namespace Academy.Models.Utils
{
    public class CourseResult : ICourseResult
    {
        private const float EXAM_POINTS_EXCELLENT_BOTTOM_LIMIT = 65f;
        private const float COURSE_POINTS_EXCELLENT_BOTTOM_LIMIT = 75f;
        private const float EXAM_POINTS_PASSED_BOTTOM_LIMIT = 30f;
        private const float COURSE_POINTS_PASSED_BOTTOM_LIMIT = 75f;
        private Grade grade;
        private float examPoints;
        private float coursePoints;
        private ICourse course;

        public CourseResult (ICourse course, float examPoints, float coursePoints)
        {
            this.course = course;
            this.examPoints = examPoints;
            this.CoursePoints = coursePoints;
            if (this.ExamPoints >= EXAM_POINTS_EXCELLENT_BOTTOM_LIMIT ||
                this.CoursePoints >= COURSE_POINTS_EXCELLENT_BOTTOM_LIMIT)
            {
                this.grade = Grade.Excellent;
            }
            else if (this.ExamPoints > EXAM_POINTS_PASSED_BOTTOM_LIMIT ||
                this.CoursePoints >= COURSE_POINTS_PASSED_BOTTOM_LIMIT)
            {
                this.grade = Grade.Passed;
            }
            else
            {
                this.grade = Grade.Failed;
            }

        }

        public ICourse Course
        {
            get
            {
                return this.course;
            }
        }

        public float CoursePoints
        {
            get
            {
                return this.coursePoints;
            }
            private set
            {
                if (value < 0 && value > 125)
                {
                    throw new ArgumentException("Course result's course points should be between 0 and 125!");
                }
                this.coursePoints = value;
            }
        }

        public float ExamPoints
        {
            get
            {
                return this.examPoints;
            }
            private set
            {
                if (value < 0 && value > 1000)
                {
                    throw new ArgumentException("Course result's exam points should be between 0 and 1000!");
                }

                this.examPoints = value;
            }
        }

        public Grade Grade
        {
            get
            {
                return this.grade;
            }
        }

        public override string ToString()
        {
            return string.Format("  * {0}: Points - {1}, Grade - {2}", 
                this.course.Name,
                this.CoursePoints,
                this.Grade);
        }
    }
}
