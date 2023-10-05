using System.Text.RegularExpressions;
namespace Controllers
{
    public class CustomerController : ICustomerController
    {
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
