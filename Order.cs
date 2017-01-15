using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Static.Class
{
    class Order
    {
        public static List<Order> Orders = new List<Order>(); 
        int id;
         
        Client client;
        List<Product> products = new List<Product>();
        DateTime timeorder;        

        public Order(Client _client)
        {
            timeorder = DateTime.Now;                       
            client = _client;              
        }

        public static void AddNewOrder(Client _client)
        {
            Orders.Add(new Order(_client));
        }

        public void AddProduct(Product _product)
        {
            products.Add(_product);
        }

        public void Print()
        {
            Console.WriteLine("Order for " + client.name);
            foreach (var i in products)
            {
                i.Print();
            }
        }        
    }
}
