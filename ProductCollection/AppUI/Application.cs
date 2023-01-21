using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductCollection.Database;

namespace ProductCollection.AppUI
{
    public class Application : Collection
    {
        public static void ListOfId()
        {
            foreach (dynamic product in Products)
            {
                Console.WriteLine("Product Id: {0}", product.Id);
            }
        }
        public static void ListOfNames()
        {
            foreach (dynamic product in Products)
            {
                Console.WriteLine("Product Name: {0}", product.Name);
            }
        }
        public static void ListOfQuantity()
        {
            foreach (dynamic product in Products)
            {
                Console.WriteLine("Product Quantity: {0}", product.Quantity);
            }
        }
        public static void ListOfPrices()
        {
            foreach (dynamic product in Products)
            {
                Console.WriteLine("Product Price: {0}", product.Price);
            }
        }
        public static void ListOfCategory()
        {
            foreach (dynamic product in Products)
            {
                Console.WriteLine("Product Category: {0}", product.Category);
            }
        }
        public static void ListOfOrderCount()
        {
            foreach (dynamic product in Products)
            {
                Console.WriteLine("Product OrderCount: {0}", product.OrderCount);
            }
        }


        public static void ListAllProducts()
        {
            Console.WriteLine("id \t Name \t\t Quantity \t Price \t Category \t OrderCount");
            foreach (var product in Products)
            {
                Console.WriteLine($"{product.id} \t {product.name} \t {product.quantity} \t\t {product.price} \t {product.category} \t {product.orderCount}");
            }
            Console.WriteLine();

        }
    }
}
