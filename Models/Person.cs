using System;
using System.Collections.Generic;

namespace Models
{
    public class Person : IComparable<Person>
    {
        public string PersonId { get; set; }
        public Fullname Fullname { get; set; }
        public DateTime BirhDate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public Person() { }
        public Person(string id)
        {
            PersonId = id;
        }
        public Person(string personId, string fullName, DateTime birhDate, string address, string phoneNumber) : this(personId)
        {
            Fullname = new Fullname(fullName);
            BirhDate = birhDate;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person other)
        {
            return !(other is null) &&
                   PersonId == other.PersonId;
        }

        public override int GetHashCode()
        {
            return -1255590651 + EqualityComparer<string>.Default.GetHashCode(PersonId);
        }

        public int CompareTo(Person other)
        {
            return PersonId.CompareTo(other.PersonId);
        }

        public static bool operator ==(Person left, Person right)
        {
            return EqualityComparer<Person>.Default.Equals(left, right);
        }

        public static bool operator !=(Person left, Person right)
        {
            return !(left == right);
        }
    }
}
