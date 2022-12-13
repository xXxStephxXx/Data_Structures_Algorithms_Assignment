using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_algorithms_library
{
    // Student inherits from the person class
    // Composite relationship with Enrollment

    //class Student : Person, IComparable<Address>
    class Student : Person, IComparable<Student>
    {
        
        public string Program { get; set; }
        public string DateRegistered { get; set; }

        // composition
        Enrollment enrol = new Enrollment();

        public Student(String Program, String DateRegistered) : base() // base(personName, personEmail, personTelNum) //Person person
        {
            this.Program = Program;
            this.DateRegistered = DateRegistered;
            Enrollment enrol = new Enrollment();
            //this.enrol = new Enrollment();
        }

        public Student(String Program, String DateRegistered, String personName, String personEmail, String personTelNum, Enrollment enrollment) : base()
        {
            Program = this.Program;
            DateRegistered = this.DateRegistered;
            personName = this.personName;
            personEmail = this.personEmail;
            personTelNum = this.personTelNum;
            enrollment = new Enrollment();
        }

        public Student()
        {
            this.Program = "no program selected";
            this.DateRegistered = "no date selected";
            this.personName = "N/A";
            this.personEmail = "N/A";
            this.personTelNum = "no number provided";
            this.enrol = new Enrollment();
        }

        public override String ToString()
        {
            return String.Format("{0} {1}", personName, Program);

            //return base.ToString();
        }

        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
                return false;

            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Student student = obj as Student;
            return this.Program == student.Program && this.DateRegistered == student.DateRegistered;

            //return base.Equals(obj);
        }

        //Part 2 written section: Reasons for selecting Program and DateRegistered for hashing
        //I have selected Program and DateRegistered for hashing because they are both properties of
        //the Student class specifically, rather than inherited properties from the Person class.
        // Using hashing techniques can help optimise efficiency when seaching and sorting because it compares names and
        // values, not just memory location.It can also speed up the sorting process through the use of a hash table,
        // which can be used to look up specific objects more quickly.

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this.DateRegistered.GetHashCode();

            //return this.Program.GetHashCode() ^ this.DateRegistered.GetHashCode();
            //return base.GetHashCode();
        }

        // To do: generate random number / salt for each instance
        // not the most secure at the moment, as the salt isn't randomly generated and saved each time, but functions for now

        public int GetHashCodeUnique(String Program, String DateRegistered)
        {
            int salt;
            salt = 1495745;
            int hashed = 0;
            //hashed = new Random().NextBytes; //(byte[], buffer);
            //salt = salt + rand // Random(0));
            hashed = HashCode.Combine(Program, DateRegistered, salt);
            // add salting to make sure it's unique
            return hashed;
        }

        // student compare to, may want to add in date registered for comparisons as well

        public int CompareTo(Student other)
        {
            return this.Program.CompareTo(other.Program);
        }

        //int IComparable<Address>.CompareTo(Address other)
        //{
        //    throw new NotImplementedException();
        //}

        public static bool operator ==(Student a, Student b) => object.Equals(a, b);
        public static bool operator !=(Student a, Student b) => !object.Equals(a, b);

    }
}
