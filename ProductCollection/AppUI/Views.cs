using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ProductCollection.Database;

namespace ProductCollection.AppUI
{
    public class Views 
    {
        public static IList<string> RequestList = new List<string>();
        public static void StartApp()
        {
            Application.ListAllProducts();

            Console.WriteLine(@"Enter ""y"" to keep adding Request\nEnter ""n"" to quit adding request\n\n What would you like to check?....y/n");
            bool Validate = true;
            while (Validate)
            {
                Console.WriteLine();
                Console.WriteLine("Add Request!....");
                var Option = Console.ReadLine().ToLower();
                switch (Option)
                {
                    case "y":

                        string Request = Console.ReadLine().ToLower();
                        RequestList.Add(Request);

                        break;

                    case "n":
                        Validate = false;
                        break;
                }
            }
            Console.WriteLine(RequestList[0]);
            Console.WriteLine();
            foreach(string Request in RequestList)
            {
                Console.WriteLine(Request);
            }
            Console.WriteLine();
        }

        public static void GetRequest()
        {
            
            for(int i=0; i< Collection.Products.Count; i++)
            {
                Collection.ListOfProperties.name = Collection.Products[i].name;
                
                Console.WriteLine(Collection.ListOfProperties.name);
            }
        }
    }
}
