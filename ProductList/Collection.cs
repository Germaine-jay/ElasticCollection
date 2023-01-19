using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ProductList
{
    internal class Collection
    {
        static List<ExpandoObject> prodlist = new List<ExpandoObject>();
        public static void ProductList()
        {
            var Products = new[]
            {
                new properties(1,"Dell xsp",200,500,"pc",1000),
                new properties(2,"Nike airforce",300,200,"Shoe",5000),
                new properties(3,"dior",100,250,"Bag",2000)
            };

            foreach (var Product in Products)
            {
                dynamic obj0 = new ExpandoObject();
                //obj0.Name = Product._Name;
                prodlist.Add(obj0);
            }

            /*dynamic obj1 = new ExpandoObject();
            obj1 = Products.product2;
            prodlist.Add(obj1);

            dynamic obj2 = new ExpandoObject();
            obj2 = Products.product3;
            prodlist.Add(obj2);*/

        }

        public static void ElasticProductList() 
        {
            foreach (var obj in prodlist)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
