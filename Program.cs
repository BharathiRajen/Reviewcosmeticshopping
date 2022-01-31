/* 

Title: Online Cosmetic Shopping 
Author: BHARATHI R
Created at: 31-Dec-2021 
Reviewed by: AKSHAYA 
Updated by: 04-Jan-2022 

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOnlineCosmetics.UserModule;
using MyOnlineCosmetics.ProductModule;
using MyOnlineCosmetics.MenuModule;

namespace MyOnlineCosmetics
{
    class Program

    {

        static void Main(string[] args)

        {


            Console.WriteLine("****************Welcome to the Nykaa world***************");
            Console.WriteLine("****************Worlds No 1 Beauty Designation******************");


            UserBO userBO = new UserBO();
            userBO.Register();

            Menu menu = new Menu();
            menu.Cosmeticmenu();
        }


    }
}
