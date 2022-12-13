using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_algorithms_library
{
    class Course
    {
        public String courseCode { get; set; }
        public String courseName { get; set; }
        public int courseCost { get; set; }

        // aggregation
        //Enrollment enrollment = new Enrollment();
        //private Enrollment enrollment_course;
        //public Enrollment enrollment_course;

        private String DEFAULT_COURSE_CODE = "N/A";
        private String DEFAULT_COURSE_NAME = "course name not found";
        private int DEFAULT_COURSE_COST = 0;

        public Course(String courseCode, String courseName, int courseCost) //Enrollment enrollment_course)
        {
            this.courseCode = courseCode;
            this.courseName = courseName;
            this.courseCost = courseCost;
            //this.enrollment_course = enrollment_course;
        }

        // throws system.stackoverflow error //
        // constructor contains enrollment
        public Course()
        {
            this.courseCode = DEFAULT_COURSE_CODE;
            this.courseName = DEFAULT_COURSE_NAME;
            this.courseCost = DEFAULT_COURSE_COST;
            //this.enrollment_course = new Enrollment();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Course course = obj as Course;
            return this.courseCode == course.courseCode && this.courseName == course.courseName && this.courseCost == course.courseCost;

            //return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return this.courseCode.GetHashCode() ^ this.courseName.GetHashCode() ^ this.courseCost.GetHashCode();
            //return base.GetHashCode();
        }

        public static bool operator ==(Course a, Course b) => object.Equals(a, b);
        public static bool operator !=(Course a, Course b) => !object.Equals(a, b);

    }
}
