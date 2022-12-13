using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_algorithms_library
{
    class Enrollment
    {
        public String dateEnrolled { get; set; }
        public int grade { get; set; }
        public String semester { get; set; }
        public Course course { get; set; }

        //public string courseCode { get; set; }
        //public string courseName { get; set; }
        //public int courseCost { get; set; }

        private String DEFAULT_DATE = "Monday 1/4/2000";
        private int DEFAULT_GRADE = 0;
        private String DEFAULT_SEMESTER = "semester not found";
        private Course DEFAULT_COURSE = new Course();


        public Enrollment(string dateEnrolled, int grade, String semester) //, Course course)
        {
            this.dateEnrolled = dateEnrolled;
            this.grade = grade;
            this.semester = semester;            
            //this.course = course;
            
            //this.course = new Course(string courseCode, string courseName, int courseCost);
        }

        public Enrollment()
        {
            this.dateEnrolled = DEFAULT_DATE;
            this.grade = DEFAULT_GRADE;
            this.semester = DEFAULT_SEMESTER;
            this.course = DEFAULT_COURSE;
        }

        public void setCourse(String courseCode, String courseName, int courseCost)
        {
            course = new Course(courseCode, courseName, courseCost);
        }

        public void setCourse(Course _course)
        {
            course = _course;
        }

        //public void setCourse(string Number, string Street, string Suburb, string Postcode, string State) 
        //{
        //    address = new Address(Number, Street, Suburb, Postcode, State);
        //}

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Enrollment enrollment = obj as Enrollment;
            return this.dateEnrolled == enrollment.dateEnrolled && this.grade == enrollment.grade && this.semester == enrollment.semester
                && this.course == enrollment.course;

                //&&  this.courseCode == course.courseCode && this.courseName == course.courseName && this.courseCost == course.courseCost;

            //return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return this.dateEnrolled.GetHashCode() ^ this.grade.GetHashCode() ^ this.semester.GetHashCode() ^ this.course.GetHashCode();
        }

        public static bool operator ==(Enrollment a, Enrollment b) => object.Equals(a, b);
        public static bool operator !=(Enrollment a, Enrollment b) => !object.Equals(a, b);

    }
}
