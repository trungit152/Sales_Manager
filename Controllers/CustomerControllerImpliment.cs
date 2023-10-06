using Models;
using System.Text.RegularExpressions;
namespace Controllers
{
    public class CustomerController : ICustomerController
    {
        public int CompareCustomerByBirthDate(Customer customer1, Customer customer2)
        {
            return customer1.BirthDate.CompareTo(customer2.BirthDate);
        }

        public int CompareCustomerByCreatedDate(Customer customer1, Customer customer2)
        {
            return customer1.CreateTime.CompareTo(customer2.CreateTime);
        }

        public int CompareCustomerById(Customer customer1, Customer customer2)
        {
            return customer1.PersonId.CompareTo(customer2.PersonId);
        }

        public int CompareCustomerByName(Customer customer1, Customer customer2)
        {
            int nameCompared = customer1.FullName.FirstName.CompareTo(customer2.FullName.FirstName);
            if (nameCompared != 0)
            {
                return nameCompared;
            }
            return customer1.FullName.MidName.CompareTo(customer2.FullName.MidName);
        }

        public int CompareCustomerByPointDESC(Customer customer1, Customer customer2)
        {
            return customer2.Point.CompareTo(customer1.Point);
        }

        public bool IsEmailValid(string email)
        {
            var pattern = @"^[0-9a-z_]+[a-z0-9.-_]*@[a-z0-9]+.[a-z]{2,4}$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }

        public bool IsNameValid(string name)
        {
            var pattern = @"^[\p{L}\p{M} ]{2,40}$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);
            return regex.IsMatch(name);
        }



        public bool IsPhoneValid(string phone)
        {
            var pattern = @"^(01|02|03|04|05|08|09)\d{8}$";
            var regex = new Regex(pattern);
            return regex.IsMatch(phone);
        }
    }
}
