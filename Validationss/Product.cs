using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validationss
{
    internal class Product
    {
        public int Number { get; set; }
        public DateTime  Date { get; set; }
        public String InventoryNo { get; set; }
        public String ObjectName { get; set; }
        public int Count { get; set; }
        public double price { get; set; }
        public String Phoneno { get; set; }
        public bool available{ get; set; }
        public bool yes { get; set; }
        public bool no { get; set; }
        public bool female{ get; set; }
        public bool male { get; set; }
        public bool pay { get; set; }
        public bool paypal { get; set; }
        public String username { get; set; }
        public String pass{ get; set; }

        //we use ststic because the list is shared for all object
        static List<Product> products = new List<Product>();

        public void save()
        {
            //this: b/c it is in the same class
            products.Add(this);
        }
        static public List<Product> getAllProduct()
        {
            return products;

        }
        public static Product findOneByName(string name)
        {
            //Product p = new Product();
            return products.Find(p => p.ObjectName == name);
        }


    }
}
