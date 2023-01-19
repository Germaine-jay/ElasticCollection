using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ProductCollection.Database
{
    public class Collection
    {
        public static List<ExpandoObject> prodlist = new List<ExpandoObject>();

        public static IList<properties> Products = new List<properties>()
        {
            new properties(1, "Dell Xps", 300, 1500, "Laptop", 1000),
            new properties(2, "sneakers", 400, 200, "Shoes", 4000),
            new properties(3, "Table", 500, 250, "Tables", 3000),
        };

        public static void ProductList()
        {
            dynamic obj0 = new ExpandoObject();
            obj0.id = Products[0].Id;
            obj0.Name = Products[0].Name;
            obj0.Quantity = Products[0].Quantity;
            obj0.Price = Products[0].Price;
            obj0.Category = Products[0].Category;
            obj0.OrderCount = Products[0].OrderCount;

            prodlist.Add(obj0);

            dynamic obj1 = new ExpandoObject();
            obj1.id = Products[0].Id;
            obj1.Name = Products[0].Name;
            obj1.Quantity = Products[0].Quantity;
            obj1.Price = Products[0].Price;
            obj1.Category = Products[0].Category;
            obj1.OrderCount = Products[0].OrderCount;

            prodlist.Add(obj0);

            dynamic obj2 = new ExpandoObject();
            obj2.id = Products[0].Id;
            obj2.Name = Products[0].Name;
            obj2.Quantity = Products[0].Quantity;
            obj2.Price = Products[0].Price;
            obj2.Category = Products[0].Category;
            obj2.OrderCount = Products[0].OrderCount;

            prodlist.Add(obj0);
        }
    }
}