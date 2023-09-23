using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Customer : Person, IEquatable<Customer>, IComparable<Customer>
    {
        public string CustomerType { get; set; }
        public int Point { get; set; }
        public DateTime CreateTime { get; set; }
        public string Email { get; set; }
        public Customer() { }
        public Customer(string customerType, int point, DateTime createTime, string email)
        {
            CustomerType = customerType;
            Point = point;
            CreateTime = createTime;
            Email = email;
        }
        public Customer(string personId, string fullName, DateTime birhDate, string address, string phoneNumber, 
            string customerType, int point, DateTime createTime, string email) : base(personId, fullName, birhDate, address, phoneNumber)
        {
            CustomerType = customerType;
            Point = point;
            CreateTime = createTime;
            Email = email;
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Customer);
        }

        public bool Equals(Customer other)
        {
            return !(other is null) &&
                   base.Equals(other) &&
                   PersonId == other.PersonId;
        }

        public override int GetHashCode()
        {
            int hashCode = 2079290131;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PersonId);
            return hashCode;
        }

        public int CompareTo(Customer other)
        {
            return PersonId.CompareTo(other.PersonId);
        }

        public static bool operator ==(Customer left, Customer right)
        {
            return EqualityComparer<Customer>.Default.Equals(left, right);
        }

        public static bool operator !=(Customer left, Customer right)
        {
            return !(left == right);
        }
    }

}
