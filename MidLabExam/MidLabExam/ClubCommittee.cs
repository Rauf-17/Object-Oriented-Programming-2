using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidLabExam
{
    internal class ClubCommittee
    {
        private Member[] members;
        private int count;

        public ClubCommittee()
        {
            members = new Member[10];
            count = 0;
        }

        public void AddMember(Member member)
        {
            members[count++] = member;
        }
    }
}
