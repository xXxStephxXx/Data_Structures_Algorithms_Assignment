using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_algorithms_library
{
    class Person
    {
        public string personName { get; set; }
        public string personEmail { get; set; }
        public string personTelNum { get; set; }
        //public int personID { get; set; }

        Address address = new Address();

        public Person(String personName, String personEmail, String personTelNum, Address address) //int personID, 
        {
            //this.personID = personID;
            this.personName = personName;
            this.personEmail = personEmail;
            this.personTelNum = personTelNum;
            this.address = new Address();
        }

        public Person()
        {
            this.personName = "DefaultCharlie";
            this.personEmail = "default@default.com";
            this.personTelNum = "01189998819991197253";
            this.address = new Address();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Person hume = obj as Person;
            return this.personName == hume.personName && this.personEmail == hume.personEmail && this.personTelNum == hume.personTelNum;
                        
            //return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return this.personName.GetHashCode() ^ this.personEmail.GetHashCode() ^ this.personTelNum.GetHashCode();
            //return base.GetHashCode();
        }

        // original code below
        //public static bool operator ==(Person a, Person b)
        //{
        //    return object.Equals(a, b);
        //}

        // updated code (the same, but looks cleaner
        public static bool operator ==(Person a, Person b) => object.Equals(a, b);
        public static bool operator !=(Person a, Person b) => !object.Equals(a, b);
    }
}
