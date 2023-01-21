using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCollection.Database
{
    public class properties
    {
        public int id;
        public string name;
        public int quantity;
        public double price;
        public string category;
        public int orderCount;

        public properties()
        {

        }
        public properties(int Id, string Name, int Quantity, int Price, string Category, int Ordercount)
        {
            id = Id;
            name = Name;
            quantity =  Quantity;
            price = Price;
            category = Category;
            orderCount = Ordercount;
        }
    }
}

