using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_app_3._0
{
    class TripManager
    {
        private CarManager carManager;

        public TripManager(CarManager manager)
        {
            carManager = manager;
        }

        public void ManageTrips()
        {
            Console.WriteLine("Trip management options coming soon...");
        }
    }
}
