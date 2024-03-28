using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Program
    {

        public void swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }


        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;

            Program p = new Program();

            Console.WriteLine("Before Swap, the value of a : {0} ", a);
            Console.WriteLine("Before Swap, the value of b : {0} ", b);

            p.swap(ref a, ref b);

            Console.WriteLine("After Swap, the value of a : {0} ", a);
            Console.WriteLine("After Swap, the value of b : {0} ", b);


            Console.ReadKey();

        }
    }
}
