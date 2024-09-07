using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicing
{
    class program
    {
        int id;
        double marks;
        public program() 
        {
            int id = 102221;
            double marks = 78.4;
            Console.WriteLine("Under The default Constructor");
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Marks : " + marks);
        }
        public program(int i, double m)
        {
            this.id = i;
            this.marks = m;
            Console.WriteLine("Under Parameterized Constructor");
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Marks : " + marks);
        }
        public program(program pr)
        {
            this.id = pr.id;
            this.marks = pr.marks;
            Console.WriteLine("Under Copy Constructor");
            Console.WriteLine("ID : " + this.id);
            Console.WriteLine("Marks : " + this.marks);
        }
        static program() 
        {
            Console.WriteLine("Under Static Constructor");
        }
        public static void Main(string[] args) 
        {
            program p = new program();
            program p1 = new program(542323,60.2);
            program p2 = new program(p1);
            program p3 = new program();




            Console.ReadKey();
        }
    }

}    