namespace Car_app_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> teamCars = new List<Car>();
            List<Tripdistance> tripList = new List<Tripdistance>();

            Car car = new Car("Default", "Default", 0, 0, 0, FuelType.Benzin);
            Console.ForegroundColor = ConsoleColor.Green;
            // Console.WriteLine("Biloplysninger indlæst!");
            /* Console.ResetColor();
            Console.ReadLine();
            Console.Clear(); */

            int choice;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("=================================");
                Console.WriteLine("|         CAR APP 2.0 MENU      |");
                Console.WriteLine("=================================");
                Console.ResetColor();

                Console.WriteLine("|   0. Toggle Engine on/off     |");
                Console.WriteLine("|   1. Add new car to Team      |");
                Console.WriteLine("|   2. Drive                    |");
                Console.WriteLine("|   3. Calculate Trip Price     |");
                Console.WriteLine("|   4. Is Palindrome            |");
                Console.WriteLine("|   5. Print current car details|");
                Console.WriteLine("|   6. Print All Team Cars      |");
                Console.WriteLine("|   7. Print Trip List          |");
                Console.WriteLine("|   8. Exit                     |");
                Console.WriteLine("---------------------------------");
                Console.Write("        Indtast dit valg: ");

                choice = int.Parse(Console.ReadLine() ?? "0");

                Console.Clear();

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Indtast 'true' for at tænde motoren, 'false' for at slukke motoren:");
                        string input = Console.ReadLine();
                        if (bool.TryParse(input, out bool turnOn))
                        {
                            car.ToggleEngine(turnOn);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ugyldigt input, prøv igen.");
                            Console.ResetColor();
                        }
                        break;

                    case 1:
                        car.ReadCarDetails(teamCars);
                        break;

                    case 2:
                        Console.Write("Indtast afstand: ");
                        double distance = double.Parse(Console.ReadLine() ?? "0");
                        car.Drive(distance);
                        double literPrice = GetFuelPrice(car.BrændStofType);
                        double price = car.CalculateTripPrice(distance, literPrice);
                        tripList.Add(new Tripdistance { Distance = distance, Date = DateTime.Now, Price = price, Car = car });
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"Prisen for turen er: {price:F2}");
                        Console.ResetColor();
                        break;

                    case 3:
                        Console.WriteLine("Indtast afstand:");
                        distance = double.Parse(Console.ReadLine() ?? "0");
                        literPrice = GetFuelPrice(car.BrændStofType);
                        price = car.CalculateTripPrice(distance, literPrice);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"Prisen for turen er: {price:F2}");
                        Console.ResetColor();
                        break;

                    case 4:
                        Console.WriteLine("Indtast kilometerstand:");
                        int km = int.Parse(Console.ReadLine() ?? "0");
                        bool isPalindrome = car.IsPalindrome(km);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"Er kilometerstanden et palindrom? {isPalindrome}");
                        Console.ResetColor();
                        break;

                    case 5:
                        car.PrintCarDetails();
                        break;

                    case 6:
                        Car.PrintAllTeamCars(teamCars, tripList);
                        break;

                    case 7:
                        Tripdistance.PrintTripList(tripList);
                        break;

                    case 8:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Afslutter programmet. God dag!!!");
                        Console.ResetColor();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ugyldigt valg, prøv igen.");
                        Console.ResetColor();
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            } while (choice != 8);
        }

        private static double GetFuelPrice(FuelType fuelType)
        {
            return fuelType switch
            {
                FuelType.Benzin => 13.5,
                FuelType.Diesel => 11.5,
                FuelType.Electric => 3.5,
                FuelType.Hybrid => 13.5,
                _ => 0
            };
        }
    }
}
