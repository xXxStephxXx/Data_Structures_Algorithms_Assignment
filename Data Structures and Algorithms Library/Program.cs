using System;
using System.Collections.Generic;

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

            String showEnrollment = "Enrollment Date: " + enrollment.dateEnrolled + "\nGrade: " + enrollment.grade + "\nSemester: " + enrollment.semester
                + showCourse2;
            // + "\nCourse code: " + enrollment2.course.courseCode + ", name: " + enrollment2.course.courseName + ", cost: $" + enrollment2.course.courseCost.ToString();
            bool equalEnrollmentTrue = enrollment.Equals(enrollment);
            bool equalEnrollmentFalse = enrollment.Equals(enrollment2);

            Console.WriteLine(showEnrollment + "\nshould be true: " + equalEnrollmentTrue + "\nshould be false: " + equalEnrollmentFalse);

            Console.WriteLine("------------- testing Address -------------");

            Address address1 = new Address("12", "test st", "test suburb", "1111", "SA");
            Address address2 = new Address();

            String showAddress = "course code: " + address1.Number + "\ncourse name: " + address1.Street + "\ncourse cost: $" + address1.Suburb + "\npostcode: "
                + address1.Postcode + "\nstate: " + address1.State;

            String showAddress2 = "Street Number: " + address2.Number + "\nStreet name: " + address2.Street + "\nSuburb: " + address2.Suburb + "\npostcode: "
                + address2.Postcode + "\nstate: " + address2.State;
            bool equalAddressTrue = address1.Equals(address1);
            bool equalAddressFalse = address1.Equals(address2);

            Console.WriteLine("\naddress 1: " + showAddress + "\naddress 2: " + showAddress2 + "\nshould be true: " + equalEnrollmentTrue + "\nshould be false: " + equalEnrollmentFalse);

            Console.WriteLine("------------- testing Student -------------");

            // creating list of student objects
            List<Student> students = new List<Student>();

            Student studentSherry = new Student();
            Student studentRose = new Student();
            Student studentGinny = new Student();
            Student studentBrandy = new Student();
            Student studentAndreas = new Student();
            Student studentLeonardo = new Student();
            Student studentDaphne = new Student();
            Student studentPetunia = new Student();
            Student studentLilly = new Student();
            Student studentSaul = new Student();

            students.Add(studentSherry = new Student { personName = "Sherry", Program = "Maths", DateRegistered = "01/07/2022" });
            students.Add(studentRose = new Student { personName = "Rose", Program = "Finance", DateRegistered = "02/09/2020" });
            students.Add(studentGinny = new Student { personName = "Ginny", Program = "Psychology", DateRegistered = "29/07/2019" });
            students.Add(studentBrandy = new Student { personName = "Brandy", Program = "Chemistry", DateRegistered = "11/11/2005" });
            students.Add(studentAndreas = new Student { personName = "Andreas", Program = "Geography", DateRegistered = "01/07/2022" });
            students.Add(studentLeonardo = new Student { personName = "Leonardo", Program = "Science", DateRegistered = "02/09/2020" });
            students.Add(studentDaphne = new Student { personName = "Daphne", Program = "Astronomy", DateRegistered = "29/07/2019" });
            students.Add(studentPetunia = new Student { personName = "Petunia", Program = "Astrology", DateRegistered = "11/11/2005" });
            students.Add(studentLilly = new Student { personName = "Lilly", Program = "Art", DateRegistered = "29/07/2019" });
            students.Add(studentSaul = new Student { personName = "Saul", Program = "Drama", DateRegistered = "11/11/2005" });

            // Linear search, not appearing in the list to use
            //students.LinearSearch(studentSherry);

            Console.WriteLine(" \n Unsorted students:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(" \n Students sorted by program in ascending order (bubble sort):");
            Utility.BubbleSortAsc(students);
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(" \n Testing Binary Search");

            String binarytest = students.BinarySearch(studentGinny).ToString();
            Console.WriteLine(binarytest);

            Console.WriteLine(" \n Students sorted by program in descending order (bubble sort):");
            Utility.BubbleSortDesc(students);
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Student student3 = new Student();
            Student student1 = new Student("Physics", "06/06/2022");

            String showStudent = "student Program: " + student3.Program + "\nDate Registered: " + student3.DateRegistered;
            String showStudent1 = "student Program: " + student1.Program + "\nDate Registered: " + student1.DateRegistered;
            bool equalStudentTrue = student3.Equals(student3);
            bool equalStudentFalse = student3.Equals(student1);

            Console.WriteLine("\nStudent1: " + showStudent + "\nStudent 2: " + showStudent1 + "\nshould be true: " + equalStudentTrue + "\nshould be false: " + equalStudentFalse);

            //student.GetHashCode

            Console.WriteLine("------------- Testing Doubly Linked Lists -------------");

            // Testing Doubly Linked Lists

            Dbl_LinkedList<Student> studentDLL = new Dbl_LinkedList<Student>();

            studentDLL.Add(new Student { personName = "Abby", Program = "Maths", DateRegistered = "01/07/2022" });
            studentDLL.Add(new Student { personName = "Katie", Program = "Finance", DateRegistered = "02/09/2020" });
            studentDLL.Add(new Student { personName = "Cameron", Program = "Psychology", DateRegistered = "29/07/2019" });
            studentDLL.Add(new Student { personName = "Timothy", Program = "Chemistry", DateRegistered = "11/11/2005" });

            foreach (Student value in studentDLL)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine(" \n After new student added last:");

            Student student_test2;

            studentDLL.AddLast(student_test2 = new Student { personName = "Amethyst", Program = "Geology", DateRegistered = "1/11/2000" });

            foreach (Student value in studentDLL)
            {
                Console.WriteLine(value);
            }

            bool studentContains = studentDLL.Contains(student_test2);
            Console.WriteLine("\n the student is already in the list = " + studentContains);

            studentDLL.RemoveFirst();
            Console.WriteLine(" \n After first student removed:");
            foreach (Student value in studentDLL)
            {
                Console.WriteLine(value);
            }

            studentDLL.RemoveLast();
            Console.WriteLine(" \n After last student removed:");
            foreach (Student value in studentDLL)
            {
                Console.WriteLine(value);
            }

            Student student_test4;

            studentDLL.AddFirst(student_test4 = new Student { personName = "Cassy", Program = "Midwifery", DateRegistered = "1/11/2000" });
            Console.WriteLine(" \n After new student added first:");
            foreach (Student value in studentDLL)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("------------- Testing Binary Trees -------------");

            // currently causes error that I'm not sure how to fix if uncommented

            //BinaryTree<Student> binary_tree_test = new BinaryTree<Student>();
            //binary_tree_test.Add(studentAndreas.personName.ToString());
            //binary_tree_test.Add(studentLeonardo.personName.ToString());
            //binary_tree_test.Add(studentSaul.personName.ToString());

            //Console.WriteLine("contents of binary tree" + binary_tree_test);

        }
    }
}
