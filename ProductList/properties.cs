using System;
using System.Collections.Generic;
using System.Text;

namespace ProductList
{
    public class properties
    {      
        public int _Id;
        public string _Name;
        public int _Quantity;
        public int _Price;
        public string _Category;
        public int _OrderCount;

        public properties()
        {

        }
        public properties(int id, string name, int quantity, int price, string category, int ordercount)
        {
            _Id= id;
            _Name= name;
            _Quantity= quantity;
            _Price= price;
            _Category= category;
            _OrderCount= ordercount;
        }
    }
}

