using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output_Parameter
{
    public class Program
    {
        public static void calculate(int x, int y, out int add, out int sub, out int mul, out int div)
        {
            add = x + y;
            sub = x - y;
            mul = x * y;
            div = x / y;
        }
        static void Main(string[] args)
        {
            int num1, num2, a, b, c, d;

            Console.WriteLine("Enter Any Values :");

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            calculate(num1, num2,out a,out b,out c,out d);

            Console.WriteLine("Addition = " +a);
            Console.WriteLine("Substration = " +b);
            Console.WriteLine("Multiplication = " +c);
            Console.WriteLine("Division = " +d);

            Console.ReadKey();
        }
    }
}
