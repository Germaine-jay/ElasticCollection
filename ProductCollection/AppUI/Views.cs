using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductCollection.Database;

namespace ProductCollection.AppUI
{
    internal class Views 
    {
        public static void StartApp()
        {
            Application.ListAllProducts();

            bool Validate = true;
            while (Validate)
            {
                Console.WriteLine(@"Enter ""y"" to keep adding Request\nEnter ""n"" to quit adding request\n\n What would you like to check?....y/n");

                var Option = Console.ReadLine().ToLower();
                switch (Option)
                {
                    case "y":
                        Console.WriteLine("Add Request!....");

                        string Request = Console.ReadLine().ToLower();
                        
                        break;
                    case "n":
                        Validate = false;
                        break;
                }
            }
        }
    }
}
