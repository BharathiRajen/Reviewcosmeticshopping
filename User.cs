using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOnlineCosmetics.UserModule
{
    class User

    {

        // Filds 

        private string Username;

        private string MailId;

        private string Password;

        private string Mobilenumber;



        // Constructer 

        public User()

        {



        }



        // Parameterlised Constructer 

        public User(string username, string mailId, string password, string mobilenumber)

        {

            this.Username = username;

            this.MailId = mailId;

            this.Password = password;

            this.Mobilenumber = mobilenumber;

        }



        //Mathods 

        //Geter and Seter 

        public string UserName { get => Username; set => Username = value; }
        public string Mailid { get => MailId; set => MailId = value; }
        public string password { get => Password; set => Password = value; }
        public string MobileNumber { get => Mobilenumber; set => Mobilenumber = value; }


        public void display()

        {


            Console.WriteLine("Username: {0}", Username);

            Console.WriteLine("Password: {0}", Password);

            Console.WriteLine("Email: {0}", MailId);

            Console.WriteLine("MobileNumber: {0}", Mobilenumber);


        }





        public bool isLogin(string Username, string password)

        {

            return ((this.Username == Username) && (this.Password == password));

        }

    }
}
