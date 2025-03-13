using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_app_2._0
{
    internal class Tripdistance
    {
        public double Distance { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public Car Car { get; set; } // Correctly define the Car property

        public override string ToString()
        {
            return $"Distance: {Distance}, Date: {Date}, Price: {Price:F2} kr";
        }

        public static void PrintTripList(List<Tripdistance> tripList)
        {
            foreach (var trip in tripList)
            {
                Console.WriteLine(trip.ToString());
            }
        }
    }
}
