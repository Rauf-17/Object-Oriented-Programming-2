using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicing
{
    internal class Car
    {
       protected string model;
       protected string color;
       protected double price;

         protected void printDetails()
        {
            Console.WriteLine("Model : " + model);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Price : " +price);
        }
    }
}
