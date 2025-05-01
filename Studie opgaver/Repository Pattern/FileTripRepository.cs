using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern
{
    public class FileTripRepository :ITripRepository
    {
        private readonly string filePath = "trips.txt";

        public List<Trip> GetTripsForCar(string regNr)
        {
            if (!File.Exists(filePath))
                return new List<Trip>();

            return File.ReadAllLines(filePath)
                       .Select(Trip.FromString)
                       .Where(t => t.CarRegNr == regNr)
                       .ToList();
        }

        public void AddTrip(Trip trip)
        {
            File.AppendAllText(filePath, trip + Environment.NewLine);
        }

        public void DeleteTrip(Trip trip)
        {
            var trips = File.ReadAllLines(filePath)
                            .Select(Trip.FromString)
                            .Where(t => !(t.CarRegNr == trip.CarRegNr && t.Date == trip.Date && t.StartTime == trip.StartTime))
                            .ToList();
            SaveAllTrips(trips);
        }

        private void SaveAllTrips(List<Trip> trips)
        {
            File.WriteAllLines(filePath, trips.Select(t => t.ToString()));
        }
    }
}

