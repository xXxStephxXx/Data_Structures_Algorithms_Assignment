﻿using System;

namespace data_structures_algorithms_library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("testing!");
            Console.WriteLine("------------- testing person -------------");

            Person person1 = new Person("paula", "paula@hume.com", "1111", new Address("15", "test st", "test suburb", "2222", "SA")); //001, 
            Person person2 = new Person("stewie", "stewie@hume.com", "2222", new Address()); //002, 

            Person person = new Person("", "", "", new Address()); //000, 

            String showPerson = "person name: " + person1.personName + "\nperson email: " + person1.personEmail + "\nperson phone: " + person1.personTelNum;
            bool equalPersonTrue = person1.Equals(person1);
            bool equalPersonFalse = person1.Equals(person2);

            Console.WriteLine(showPerson + "\nshould be true: " + equalPersonTrue + "\nshould be false: " + equalPersonFalse);

            Console.WriteLine("------------- testing course -------------");

            Course course1 = new Course("1222", "Advanced Chemistry", 700); //, new Enrollment());
            Course course2 = new Course("1333", "Psychology", 500); //, new Enrollment());


            String showCourse = "course code: " + course1.courseCode + "\ncourse name: " + course1.courseName + "\ncourse cost: $" + course1.courseCost;
            String showCourse2 = "course code: " + course2.courseCode + "\ncourse name: " + course2.courseName + "\ncourse cost: $" + course2.courseCost;
            bool equalCourseTrue = course1.Equals(course1);
            bool equalCourseFalse = course1.Equals(course2);

            Console.WriteLine(showCourse + "\nshould be true: " + equalCourseTrue + "\nshould be false: " + equalCourseFalse);

            Console.WriteLine("------------- testing Enrollment -------------");

            Enrollment enrollment = new Enrollment("Tuesday 30/5/2020", 213, "semester 1"); //, course1);
            Enrollment enrollment2 = new Enrollment("Tuesday 30/5/2022", 214, "semester 2"); //, new Course("1444", "Electronics", 600)); //, new Enrollment()));

            enrollment.setCourse(course1);

            // may need to fix up the bit below for enrollment and course

            String showEnrollment = "Enrollment Date: " + enrollment.dateEnrolled + "\nGrade: " + enrollment.grade + "\nSemester: " + enrollment.semester
                + showCourse2;
            // + "\nCourse code: " + enrollment2.course.courseCode + ", name: " + enrollment2.course.courseName + ", cost: $" + enrollment2.course.courseCost.ToString();
            bool equalEnrollmentTrue = enrollment.Equals(enrollment);
            bool equalEnrollmentFalse = enrollment.Equals(enrollment2);

            Console.WriteLine(showEnrollment + "\nshould be true: " + equalEnrollmentTrue + "\nshould be false: " + equalEnrollmentFalse);

            Console.WriteLine("------------- testing Address -------------");

            //Address address1 = new Address("12", "test st", "test suburb", "1111", "SA");
            //Address address2 = new Address();

            //String showAddress = "course code: " + address1.Number + "\ncourse name: " + address1.Street + "\ncourse cost: $" + address1.Suburb + "\npostcode: "
            //    + address1.Postcode + "\nstate: " + address1.State;

            //String showAddress2 = "Street Number: " + address2.Number + "\nStreet name: " + address2.Street + "\nSuburb: " + address2.Suburb + "\npostcode: "
            //    + address2.Postcode + "\nstate: " + address2.State;
            //bool equalAddressTrue = address1.Equals(address1);
            //bool equalAddressFalse = address1.Equals(address2);

            //Console.WriteLine("\naddress 1: " + showAddress + "\naddress 2: " + showAddress2 + "\nshould be true: " + equalEnrollmentTrue + "\nshould be false: " + equalEnrollmentFalse);

            Console.WriteLine("------------- testing Student -------------");

            Student student = new Student();
            Student student1 = new Student("Physics", "Wednesday 06/06/2022");

            String showStudent = "student Program: " + student.Program + "\nDate Registered: " + student.DateRegistered;
            String showStudent1 = "student Program: " + student1.Program + "\nDate Registered: " + student1.DateRegistered;
            bool equalStudentTrue = student.Equals(student);
            bool equalStudentFalse = student.Equals(student1);

            Console.WriteLine("\nStudent1: " + showStudent + "\nStudent 2: " + showStudent1 + "\nshould be true: " + equalStudentTrue + "\nshould be false: " + equalStudentFalse);

            //student.GetHashCode

        }
    }
}
