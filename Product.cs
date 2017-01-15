using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Static.Class
{
    class Product
    {
        public static List<Product> Products = new List<Product>(); 

        public int id;
        public string name;
        public decimal price;
        public string description;
        public int amount;

        public Product(int _id, string _name, decimal _price, string _description, int _amount) 
        {
            id = _id;
            name = _name;
            price = _price;
            description = _description;
            amount = _amount;
        }
                
        public static void AddNewProduct(int _id, string _name, decimal _price, string _description, int _amount)
        {
            Products.Add(new Product(_id, _name, _price, _description, _amount));
        }

        public void Print()
        {
            Console.WriteLine(id + "\t" + name + "\t" + price + "\t" + description + "\t" + amount);
        }

        public static void PrintAllProduct()
        {
            foreach (var i in Products)
                i.Print();
        }
        
        public static void Amount_CheckPrint()
        {
            for (int j = 0; j < Products.Count; j++)
            {
                if (Products[j].amount == 0)
                {
                    Products.RemoveAt(j);
                    j--;
                    continue;                    
                }                
            }        
        }
    }
}
