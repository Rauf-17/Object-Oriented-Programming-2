using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidLabExam
{
    class Address
    {
        public int HouseNo { get; set; }
        public int RoadNo { get; set; }
        public string Area { get; set; }

        public string District { get; set; }

        public Address(int houseNo, int roadNo, string area, string district)
        {
            HouseNo = houseNo;
            RoadNo = roadNo;
            Area = area;
            District = district;
        }
    }
}
