using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    class Labor : Employee
    {
        public int UserRating { get; }
        public int ChargePerService { get; }
        public int NoOfService { get; set; }

        public Labor(string name, string address, int userRating, int chargePerService, int noOfService)
            : base(name, address)
        {
            la += 1;
            UserRating = userRating;
            ChargePerService = 500;
            NoOfService = noOfService;
        }

        public override void Showinfo()
        {
            base.Showinfo();
            Console.WriteLine("User Rating :" + UserRating);
            Console.WriteLine("Charge Per Service :" + ChargePerService);
            Console.WriteLine("No Of Service :" + NoOfService);

            EmployeeStatus();
            TotalEarn();

        }


        public override void EmployeeStatus()
        {

            if (UserRating > 70 && NoOfService >= 10)
            {
                Console.WriteLine("Employee is eligible for a bonus.");
            }
            else
            {
                Console.WriteLine("Employee is not eligible for a bonus.");
            }
        }
        public void TotalEarn()
        {
            int totalEaring = ChargePerService * NoOfService;
            Console.WriteLine("Total Earning = " + totalEaring + "Taka");
        }
    }
}
