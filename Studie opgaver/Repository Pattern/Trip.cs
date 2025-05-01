using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern
{
    public class Trip
    {
        public string CarRegNr { get; }
        public double Distance { get; }
        public DateTime Date { get; }
        public TimeSpan StartTime { get; }
        public TimeSpan EndTime { get; }
        
        public Trip(string carRegnr, double distance, DateTime date,TimeSpan starTime, TimeSpan endTime)
        {
            CarRegNr = carRegnr;
            Distance = distance;
            Date = date;
            StartTime = starTime;
            EndTime = endTime;
        }

        public override string ToString()
        {
            return $"{CarRegNr},{Distance},{Date},{StartTime},{EndTime}";
        }

        public static Trip FromString(string input)
        {
            var parts = input.Split(',');
            return new Trip(parts[0], double.Parse(parts[1]), DateTime.Parse(parts[2]), TimeSpan.Parse(parts[3]), TimeSpan.Parse(parts[4]));
        }
    }
    
}
