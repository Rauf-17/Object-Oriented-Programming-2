using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Auto_Implemented_Property
{

    public class Customer
    {
        public double totalPurchase { get; set; }
        private string CustomerName { get; set; }
        private int CustomerID { get; set; }

        public Customer(double Purchase, string Name, int ID)
        {
            totalPurchase = Purchase;
            CustomerName = Name;
            CustomerID = ID;

        }
        public void ShowDetails()
        {
            Console.WriteLine("Total Purchase = " + totalPurchase);
            Console.WriteLine("Customer Name: " + CustomerName);
            Console.WriteLine("Customer ID: " + CustomerID);
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Customer cs = new Customer(6353.56,"Rauf",3207);
            cs.ShowDetails();
            cs.totalPurchase += 463.53;
            Console.WriteLine("After Another Purchase: ");
            cs.ShowDetails();
            

            Console.ReadKey();
           
        }
    }
}
