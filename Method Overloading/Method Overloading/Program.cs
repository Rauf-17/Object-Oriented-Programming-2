using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    public class Student
    {
        public void showDetails(string id)
        {           
            Console.WriteLine("ID: " + id);
        }

        public void showDetails(string name,string dept)
        {        
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Department: " + dept);
        }
        public void showDetails(double cgpa,string doB)
        {
                Console.WriteLine("CGPA: " + cgpa);
                Console.WriteLine("Date Of Birth: " + doB);           
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student's Information");
            
            Student s1 = new Student();
            s1.showDetails("21-45779-3");
            s1.showDetails("Raufull Islam Rauf", "CSE");
            s1.showDetails(3.91, "17 Feb, 2002");
 
            Console.ReadKey();
            

        }
    }
}
