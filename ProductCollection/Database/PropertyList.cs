using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProductCollection.Database
{
    public class PropertyList : Application
    {
        public static List<ExpandoObject> propertylist = new List<ExpandoObject>();
        public static Dictionary<string, object>? AllProperties;

        public static void AllProp(Dictionary<string, object>? AllProperties)
        {
            AllProperties.Add("id",ListOfId);
            AllProperties.Add("name",ListOfNames);
            AllProperties.Add("quantity",ListOfQuantity);
            AllProperties.Add("prices",ListOfPrices);
            AllProperties.Add("category",ListOfCategory);
            AllProperties.Add("count",ListOfOrderCount);
        }
        public static void Properties()
        {
            AllProp(AllProperties);
            foreach (var o in AllProperties)
            {
                Console.WriteLine(o.Value);
            }
        }

    }
}
