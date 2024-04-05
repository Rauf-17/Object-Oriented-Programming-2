using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params_Parameter
{
    internal class Program
    {
        public static void print(params int[]numbers)
        {
            Console.WriteLine("\nThere is {0} element :", numbers.Length);
            for(int i = 0;i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]+ " ");

            }
        }
        static void Main(string[] args)
        {
            print();
            print(10, 20);
            print(20, 30,40);

            Console.ReadKey();
        }
    }
}
