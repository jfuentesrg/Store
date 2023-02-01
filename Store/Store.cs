using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public static class Store
    {
        public static HashSet<Customer> Customers = new HashSet<Customer>();
        public static HashSet<Product> Products = new HashSet<Product>();


        public static HashSet<Order> Orders = new HashSet<Order>();

        //which tracks Customers, Orders, and Products
    }
}
