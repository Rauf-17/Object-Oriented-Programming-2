using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    public abstract class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public string joinDate { get; set; }

        public Player(int id, string name, double salary,string joindate)
        {
            Id = id;
            Name = name;
            Salary = salary;
            joinDate = joindate;
        }
        public abstract void showInfo();
         
        
    }
    public class Cricketer : Player
    {
        public int totalRun { get; set; }
        public int totalWiclet { get; set; }

        public Cricketer(int id, string name, double salary, string joindate, int totalrun, int totalwicket)
            : base(id, name, salary, joindate)
        {
            totalRun = totalrun;
            totalWiclet = totalwicket;    
        }
        public override void showInfo()
        {
            Console.WriteLine("ID: " + Id);          
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Joining Date: " + joinDate);
            Console.WriteLine("Total Runs: " + totalRun);
            Console.WriteLine("Total Wickets: " + totalWiclet);

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cricketer c1 = new Cricketer(164, "Raufull Islam Rauf", 35000, "11 Oct, 2021", 6524, 51);
            c1.showInfo();
            Console.ReadKey();
        }
    }
}
