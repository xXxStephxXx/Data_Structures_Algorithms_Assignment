using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_algorithms_library
{
    class Address
    {
        public string Number { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }

        string DEFAULT_NUMBER = "0";
        string DEFAULT_STREET = "no street given";
        string DEFAULT_SUBURB = "no suburb given";
        string DEFAULT_POSTCODE = "no postcode given";
        string DEFAULT_STATE = "no state given";

        public Address()
        {
            this.Number = DEFAULT_NUMBER;
            this.Street = DEFAULT_STREET;
            this.Suburb = DEFAULT_SUBURB;
            this.Postcode = DEFAULT_POSTCODE;
            this.State = DEFAULT_STATE;
        }

        public Address(string Number, string Street, string Suburb, string Postcode, string State)
        {
            this.Number = Number;
            this.Street = Street;
            this.Suburb = Suburb;
            this.Postcode = Postcode;
            this.State = State;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Address address = obj as Address;
            return this.Number == address.Number && this.Street == address.Street && this.Suburb == address.Suburb
                && this.Postcode == address.Postcode && this.State == address.State;

            //return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode() ^ this.Street.GetHashCode() ^ this.Suburb.GetHashCode() ^ this.Postcode.GetHashCode() ^ this.State.GetHashCode();
            //return base.GetHashCode();
        }

        public static bool operator ==(Address a, Address b) => object.Equals(a, b);
        public static bool operator !=(Address a, Address b) => !object.Equals(a, b);
    }
}
