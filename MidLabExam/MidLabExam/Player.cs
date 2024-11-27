using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidLabExam
{
    internal class Player : Member
    {
        public double Salary { get; set; }

        public string PlayingPosition { get; set; }
        public int CurrentRanking { get; set; }

        public bool PlayingStatus { get; set; }

        public Player(string id, string name, Address address, double salary, string playingPosition, int currentRanking) : base(id, name, address)
        {
            Salary = salary;

            PlayingPosition = playingPosition;

            CurrentRanking = currentRanking;

            PlayingStatus = currentRanking >= 70 && currentRanking <= 100;
        }



         

    }
}
