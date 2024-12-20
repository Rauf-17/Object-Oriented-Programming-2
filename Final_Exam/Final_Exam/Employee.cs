using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    class Employee
    {
        protected static int mn = 1;
        protected static int la = 1;
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }


        public Employee(string name, string address)
        {

            if (this.GetType() == typeof(Manager))
            {
                Id = "PM-";
                if (mn < 10)
                {
                    Id += "0" + mn.ToString();
                }
                else { Id += mn.ToString(); }
            }
            else
            {
                Id = "PL-";
                if (la < 10)
                {
                    Id += "00" + la.ToString();
                }
                else if (la < 100)
                {
                    Id += "0" + la.ToString();
                }
                else { Id += la.ToString(); }
            }
            Name = name;
            Address = address;
        }

        public virtual void Showinfo()
        {
            Console.WriteLine("ID :" + Id);
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("Address :" + Address);
        }
        public virtual void EmployeeStatus()
        {
            Console.WriteLine("Eligable!");
        }

    }
}
