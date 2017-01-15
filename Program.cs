using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Static.Class
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("\nClients:\n");
            Client.AddNewCliennt(0, "Vasya", "Frunze 1", "000988888", 10);
            Client.AddNewCliennt(1, "Olha", "Vasylk 20", "098888800", 20);
            Client.AddNewCliennt(1, "Valya", "Vasylk 20", "098888800", 55);
            Client.PrintAllClient();
            Console.WriteLine("\nClients with discount over 50%: ");
            Client.Discount_Print();
            Console.WriteLine("\nAll Products:");
            Product.AddNewProduct(0, "Smartphone", 700, "Apple IPhone", 10 );
            Product.AddNewProduct(1, "Smartphone", 900, "Samsung Phone", 0);
            Product.AddNewProduct(2, "Smartphone", 800, "Xiaomi Phone", 2);
            Product.PrintAllProduct();
            
            Product.Amount_CheckPrint();
            Console.WriteLine("\nAll Products available to order:");
            Product.PrintAllProduct();
            
            Order NewOrder = new Order(Client.Clients[0]);            
            
            NewOrder.AddProduct(Product.Products[0]);
            NewOrder.AddProduct(Product.Products[0]);
            NewOrder.AddProduct(Product.Products[1]);
            
            Console.ReadKey();
        }
    }
}
