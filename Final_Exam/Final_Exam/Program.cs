using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    
    class Program
    {
        static void Main(string[] args)
        {
            ServiceProvider.Inset(new Manager("Shuvo", "Uttara", 5));
            ServiceProvider.Inset(new Manager("Jahid", "Badda", 1));
            ServiceProvider.Inset(new Labor( "Sohan", "Mirpur", 85,500, 20));
            ServiceProvider.Inset(new Labor("Jisan", "Kuril", 65,500, 44));
            ServiceProvider.Inset(new Labor("Numan", "Banani", 88,500, 3));

            ServiceProvider.ProvideDetails();
            ServiceProvider.SkilledWorker();

            Console.ReadKey();
        }
    }
}
