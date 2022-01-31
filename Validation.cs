using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MyOnlineCosmetics.UserModule
{
    class Validation
    {

        string password, email;
        public string validatePassword(string password)
        {
            Regex regex = new Regex("^[A-Z][\\S][a-z0-9][@$%!]{8,15}$");

            if (!regex.IsMatch(password))
            {
                Console.WriteLine("Invalid Password Format");
                Console.WriteLine("Enter Valid Password");
                this.password = Console.ReadLine();
                validatePassword(this.password);
            }
            return this.password;
        }

        public string validateEmail(string email)
        {
            Regex regex = new Regex("^[a-z0-9!#$]@[a-z].[com]$");
            if (!regex.IsMatch(email))
            {
                Console.WriteLine("Invalid Email Address");
                Console.WriteLine("Enter valid mail address:");
                this.email = Console.ReadLine();
                validateEmail(this.email);
            }
            return this.email;
        }

    }
}
