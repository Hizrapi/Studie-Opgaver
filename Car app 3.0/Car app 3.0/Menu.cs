using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_app_3._0
{
    public class Menu
    {
        public void Usermenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  ╔════════════════════════════════════════╗");
            Console.WriteLine("  ║           CAR MANAGEMENT MENU          ║");
            Console.WriteLine("  ╠════════════════════════════════════════╣");
            Console.WriteLine("  ║  1. Car Owner Funktions                ║");
            Console.WriteLine("  ║  2. Car Funktions                      ║");
            Console.WriteLine("  ║  3. Trip Funktions                     ║");
            Console.WriteLine("  ║  4. Print all Info                     ║");
            Console.WriteLine("  ║  0. Exit                               ║");
            Console.WriteLine("  ╚════════════════════════════════════════╝");
            Console.Write("        Choose: ");
            Console.ResetColor();
        }

        public void CarOwnerMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  ╔════════════════════════════════════════╗");
            Console.WriteLine("  ║           CAR MANAGEMENT MENU          ║");
            Console.WriteLine("  ║                CAR OWNER               ║");
            Console.WriteLine("  ╠════════════════════════════════════════╣");
            Console.WriteLine("  ║  1. Add new Car Owner                  ║");
            Console.WriteLine("  ║  2. Show Car Owners                    ║");
            Console.WriteLine("  ║  3. Remove a Car Owner                 ║");
            Console.WriteLine("  ║  4. Choose Car Owner                   ║");
            Console.WriteLine("  ║  5. Return to Main                     ║");
            Console.WriteLine("  ╚════════════════════════════════════════╝");
            Console.Write("        Choose: ");
            Console.ResetColor();
        }

        public void CarMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  ╔════════════════════════════════════════╗");
            Console.WriteLine("  ║           CAR MANAGEMENT MENU          ║");
            Console.WriteLine("  ║                   CARS                 ║");
            Console.WriteLine("  ╠════════════════════════════════════════╣");
            Console.WriteLine("  ║  1. Add Car                            ║");
            Console.WriteLine("  ║  2. Add Fuel to Car                    ║");
            Console.WriteLine("  ║  3. Change Tires on car                ║");
            Console.WriteLine("  ║  4. Get Car to service                 ║");
            Console.WriteLine("  ║  5. Show Cars                          ║");
            Console.WriteLine("  ║  6. Remove Car                         ║");
            Console.WriteLine("  ║  7. Choose Car                         ║");
            Console.WriteLine("  ║  8. Turn Engine on/off                 ║");
            Console.WriteLine("  ║  9. Return to Main                     ║");
            Console.WriteLine("  ╚════════════════════════════════════════╝");
            Console.Write("        Choose: ");
            Console.ResetColor();
        }

        public void TripMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  ╔════════════════════════════════════════╗");
            Console.WriteLine("  ║           CAR MANAGEMENT MENU          ║");
            Console.WriteLine("  ║                  TRIPS                 ║");
            Console.WriteLine("  ╠════════════════════════════════════════╣");
            Console.WriteLine("  ║  1. Take a Trip                        ║");
            Console.WriteLine("  ║  2. Show Trips from current Car        ║");
            Console.WriteLine("  ║  3. Remove Trips                       ║");
            Console.WriteLine("  ║  4. Return to Main                     ║");
            Console.WriteLine("  ╚════════════════════════════════════════╝");
            Console.Write("        Choose: ");
            Console.ResetColor();
        }
    }
}


