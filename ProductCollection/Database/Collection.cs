﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Dynamic;
using System.Text;

namespace ProductCollection.Database
{
    public class Collection
    {
        public static dynamic ListOfProperties = new ExpandoObject();

        public static IList<properties> Products = new List<properties>()
        {
            new properties(1, "Dell Xps", 300, 1500, "Laptop", 1000),
            new properties(2, "sneakers", 400, 2000, "Shoes", 4000),
            new properties(3, "wood Table", 500, 250, "Tables", 3000),
        };

        public static void propList()
        {
            foreach(var property in Products)
            {
                ListOfProperties.Id = property.id;
                ListOfProperties.Name = property.name;
                ListOfProperties.Quantity = property.quantity;
                ListOfProperties.Price = property.price;
                ListOfProperties.Category = property.category;
                ListOfProperties.OrderCount = property.orderCount;
            }
        }

        public static void use()
        {
            foreach (var property in (IDictionary<String, Object>)ListOfProperties)
            {
                Console.WriteLine(property);
            }
        }

    }
}