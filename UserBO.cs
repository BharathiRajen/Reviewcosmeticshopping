using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MyOnlineCosmetics.UserModule
{
    class UserBO

    {

        public void Register()

        {

            ConsoleKeyInfo key;
            string passwd = "";

            //Validation validation = new Validation();

            List<User> userlist = new List<User>();

            Random rand = new Random();
/*
            Console.WriteLine("****************Welcome to the Nykaa world***************");
            Console.WriteLine("****************Worlds No 1 Beauty Designation******************");
*/

            int choice = -1;

            while (choice != 3)

            {
                Console.WriteLine("To quickly find your favourites items, saved addresses and payments");
                Console.WriteLine("0. Display Products Menu");
                Console.WriteLine("1. Register for New user");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                Console.Write("Your choice: ");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)

                {
                    case 1:

                        User user = new User();
                        user.UserName = " ";
                        while (user.UserName == " ")

                        {

                            Console.Write("Enter your username: ");

                            user.UserName = Console.ReadLine();

                            Regex usernameRegex = new Regex(@"^[a-zA-Z]+$");

                            Match match = usernameRegex.Match(user.UserName);

                            if (!match.Success)

                            {

                                Console.WriteLine("You have entered an invalid username.\n ********************!!Kindly use only Alphabets!!********************");

                                user.UserName = " ";

                            }

                        }

                        Console.Write("Enter new password: ");

                        //user.password = Console.ReadLine();

                        Regex regex = new Regex("^[A-Z][\\S][a-z0-9][@$%!]{8,15}$");

                        //Match match = regex.Match(user.UserName);

                        /*if (!match.Success)

                        {

                            Console.WriteLine("You have entered an invalid username.\n ********************!!Kindly use only Alphabets!!********************");

                            user.UserName = " ";


                            user.Mailid = " ";
                        }*/

                        do
                        {

                            key = Console.ReadKey(true);

                            // Backspace Should Not Work
                            if (key.Key != ConsoleKey.Backspace)
                            {
                                passwd += key.KeyChar;

                                Console.Write("*");
                            }
                            else
                            {
                                if (passwd.Length > 0 && passwd.Length < 5)
                                {
                                    passwd = passwd.Substring(0, (passwd.Length - 1));
                                    Console.Write("\b \b");
                                }
                            }

                        }

                        // Stops Receving Keys Once Enter is Pressed
                        while (key.Key != ConsoleKey.Enter);
                        {

                            Console.WriteLine();
                            //Console.WriteLine("The Password You entered is : " + passwd);
                        }


                        while (user.Mailid == " ")

                        {

                            Console.Write("Enter your email: ");

                            user.Mailid = Console.ReadLine();

                            Regex usernameRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

                            Match match = usernameRegex.Match(user.Mailid);

                            if (!match.Success)

                            {

                                Console.WriteLine("Please enter the valid email id.\n ******************** !!Use format as local-part@domain!! ********************");

                                user.Mailid = " ";

                            }

                        }

                        user.MobileNumber = " ";

                        while (user.MobileNumber == " ")

                        {

                            Console.Write("Enter phone: ");

                            user.MobileNumber = Console.ReadLine();

                            Regex phoneRegex = new Regex(@"^[0-9]\d{9}$");

                            Match match = phoneRegex.Match(user.MobileNumber);

                            if (!match.Success)

                            {

                                Console.WriteLine("You have entered an invalid mobile number.\n ************************** Kindly use 10 digit**************************");

                                user.MobileNumber = " ";

                            }

                        }


                        userlist.Add(user);

                        break;


                        case 2:



                        Console.Write("Enter Username: ");

                        string Username;



                        Username = Console.ReadLine();

                        Console.Write("Enter password: ");

                        string password = Console.ReadLine();

                        for (int i = 0; i < userlist.Count; i++)

                        {

                            if (userlist[i].isLogin(Username, password))

                            {

                                userlist[i].display();

                                break;

                            }

                        }
                        break;
                        case 3:



                        //exit 

                        break;
                        default:



                        Console.WriteLine("\nWrong menu item.\n");

                        break;





                }

            }

                       Console.ReadLine();
        }

    }
}
