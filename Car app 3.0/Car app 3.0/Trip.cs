using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_app_3._0
{
    public class Trip
    {
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public int Distance { get; set; }

        public Trip(string startLocation, string endLocation, int distance)
        {
            StartLocation = startLocation;
            EndLocation = endLocation;
            Distance = distance;
        }
    }
}
