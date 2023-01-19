using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCollection.Database
{
    public class properties
    {
        public int Id;
        public string Name;
        public int Quantity;
        public double Price;
        public string Category;
        public int OrderCount;

        public properties()
        {

        }
        public properties(int id, string name, int quantity, int price, string category, int ordercount)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Price = price;
            Category = category;
            OrderCount = ordercount;
        }
    }
}

