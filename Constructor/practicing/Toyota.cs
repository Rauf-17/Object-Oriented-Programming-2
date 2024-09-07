using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicing
{
     class Toyota : Car
    {
        public float mileage;

       protected void showMileage() 
        {
            Console.WriteLine ("Mileage : "+ mileage + "k.M");
        }
        internal class Program
        {
            static void Main(string[] args)
            {

                Toyota myCar = new Toyota();

                myCar.model = "Allion";
                myCar.color = "Silver";
                myCar.price = 1230000;
                myCar.mileage = 9;

                myCar.printDetails();
                myCar.showMileage();





                Console.ReadKey();
            }
        }
    }

}
