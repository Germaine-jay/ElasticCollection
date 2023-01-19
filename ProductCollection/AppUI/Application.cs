using ProductCollection.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCollection.AppUI
{
    public class Application : Collection
    {
        public static void ListOfNames()
        {
            foreach (dynamic product in Products)
            {
                Console.WriteLine("ID:{0}"product.Name);
            }
        }

        public static void ListAllProducts()
        {
            Console.WriteLine("id\tName\t\tQuantity\tPrice\tCategory\tOrderCount");
            foreach (var product in Products)
            {
                Console.WriteLine($"{product.Id}\t{product.Name}\t{product.Quantity}\t{product.Price}\t\t{product.Category}\t{product.OrderCount}");
            }
            Console.WriteLine();

        }
    }
}
