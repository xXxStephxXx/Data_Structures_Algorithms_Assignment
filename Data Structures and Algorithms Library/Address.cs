using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_algorithms_library
{
    class Address
    {
        public String Number { get; set; }
        public String Street { get; set; }
        public String Suburb { get; set; }
        public String Postcode { get; set; }
        public String State { get; set; }

        String DEFAULT_NUMBER = "0";
        String DEFAULT_STREET = "no street given";
        String DEFAULT_SUBURB = "no suburb given";
        String DEFAULT_POSTCODE = "no postcode given";
        String DEFAULT_STATE = "no state given";

        public Address()
        {
            this.Number = DEFAULT_NUMBER;
            this.Street = DEFAULT_STREET;
            this.Suburb = DEFAULT_SUBURB;
            this.Postcode = DEFAULT_POSTCODE;
            this.State = DEFAULT_STATE;
        }

        public Address(String Number, String Street, String Suburb, String Postcode, String State)
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
