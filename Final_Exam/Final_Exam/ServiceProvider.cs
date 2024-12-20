using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    class ServiceProvider
    {
        public static List<Employee> employees = new List<Employee>();
        public static void Inset(Employee employee)
        {
            employees.Add(employee);
        }

        public static void ProvideDetails()
        {
            Console.WriteLine("Employee Details:");
            foreach (var employee in employees)
            {
                employee.Showinfo();
            }
        }

        public static void SkilledWorker()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Skilled Workers");
            Console.WriteLine("\n");
            foreach (var laborer in employees.FindAll(e => e is Labor).Cast<Labor>().Where(l => l.UserRating > 80))
            {
                laborer.Showinfo();
            }
        }
    }
}
