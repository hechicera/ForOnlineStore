using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Static.Class
{

    class Client
    {        
        public static List<Client> Clients = new List<Client>();      

        int id;
        public string name;
        string adress;
        string phone;
        int discount;

        public Client(int _id, string _name, string _adress, string _phone, int _discount)
        {
            id = _id;
            name = _name;
            adress = _adress;
            phone = _phone;
            discount = _discount;
        }

        public static void AddNewCliennt(int _id, string _name, string _adress, string _phone, int _discount)
        {
            Clients.Add(new Client(_id, _name, _adress, _phone, _discount));
        }

        public void Print()
        {
            Console.WriteLine(id + "\t" + name + "\t" + adress + "\t" + phone + "\t" + discount);
        }

        public static void PrintAllClient()
        {
            foreach (var i in Clients)
                i.Print();
        }
        
        public static void Discount_Print()
        {
            foreach (var i in Clients)
            {
                if (i.discount > 50)
                    i.Print();
            }
        }     
         
        }
    
   
}
