using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern
{
    public interface ITripRepository
    {
        List<Trip> GetTripsForCar(string regNr);
        void AddTrip(Trip trip);
        void DeleteTrip(Trip trip);

    }
}
