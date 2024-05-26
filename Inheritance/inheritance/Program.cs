using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Animals
    {
        public string color;
    }
    public class Dog : Animals
    {
        public string type;


        public void showDetails()
        {
            Console.WriteLine("Color of The Animal: " + color);
            Console.WriteLine("Type of The Animal: " +  type);
        }

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
             
            Dog dog = new Dog();
            dog.color = "Red";
            dog.type = "German Shepard";
            dog.showDetails();

            Console.ReadKey();
        }
    }
}
