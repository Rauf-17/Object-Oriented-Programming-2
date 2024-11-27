using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidLabExam
{
    class Staff : Member
    {
        public string Position { get; set; }

        public Staff(string id, string name, Address address, string position) : base(id, name, address)
        {
            Position = position;
        }

        public bool PlayerStatus(Player player)
        {
            return player.CurrentRanking >= 75 && player.CurrentRanking <= 100;
        }

        public void PlayerStatusDetails(Player player)
        {
            if (PlayerStatus(player))
            {
                Console.WriteLine(player.Name + " is Eligiable for Playing");
                Member.GetAllDetails(player);
            }
        }

        

    }
}
