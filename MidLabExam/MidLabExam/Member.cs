using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidLabExam
{
    internal class Member
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }

        public Member(string id, string name, Address address)
        {
            Id = id;
            Name = name;
            Address = address;
        }

        public static void GetAllDetails(Member member)
        {   if (member.GetType() == typeof(Staff))

            { Staff s = (Staff)member;
                Console.WriteLine("ID: " + s.Id);
                Console.WriteLine("Name: " + s.Name);
                Console.WriteLine("Address: " + s.Address.HouseNo + "," + s.Address.RoadNo + "," + s.Address.Area + "," + s.Address.District);
                Console.WriteLine("Position:" + s.Position);
            }

            else
            {
                Player p = (Player)member;
                Console.WriteLine("ID: " + p.Id);
                Console.WriteLine("Name: " + p.Name);
                Console.WriteLine("Address: " + p.Address.HouseNo + "," + p.Address.RoadNo + "," + p.Address.Area + "," + p.Address.District);
                Console.WriteLine("Salary :" + p.Salary);
                Console.WriteLine("Player Position: " +p.PlayingPosition);
                Console.WriteLine("Current Raking: " +p.CurrentRanking);
                Console.WriteLine("Playing Status: " + p.PlayingStatus);
            }
            
        }
    }
}
