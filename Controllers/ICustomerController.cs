using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public interface ICustomerController
    {
        bool IsNameValid(string name);
        bool IsEmailValid(string email);
        bool IsPhoneValid(string phone);
    }
}
