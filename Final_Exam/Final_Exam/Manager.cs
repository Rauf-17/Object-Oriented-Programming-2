using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    class Manager : Employee
    {
        public int YearOfExperience { get; }


        public Manager(string name, string address, int yearOfExperience) : base(name, address)
        {
            mn += 1;
            YearOfExperience = yearOfExperience;
        }

        public override void Showinfo()
        {
            base.Showinfo();
            Console.WriteLine("Year Of Experience :" + YearOfExperience);
            EmployeeStatus();
        }

        public override void EmployeeStatus()
        {
            if (YearOfExperience > 2)
            {
                Console.WriteLine("Employee is Eligable for Bonus");
            }
            else
            {
                Console.WriteLine("Employee is not Eligable for Bonus");
            }
        }
    }
}
