using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property
{
    class student
    {
        private string id = "21-45777-3";
        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.ID = ("21-45779-3");
            Console.WriteLine(s.ID);
            Console.ReadKey();

        }
    }
}
