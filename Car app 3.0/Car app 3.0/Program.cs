using Car_app_3._0.UI;
using System.Xml.Linq;

namespace Car_app_3._0
{
    internal class Program
    {
        static CarOwnerManager carOwnerManager = new CarOwnerManager();
        static List<CarOwner> carOwners = new List<CarOwner>();
        static CarManager carManager = new CarManager();
        static List<Car> cars = new List<Car>();

        /// <summary>
        /// Opretter 2 objecter, og er 2 constructore involveret. (MenuManger & standardIConsole.)
        /// Det betyder at RealConsole som er i IConsole, indlæser indput og gemmer dem.
        /// Menumanger, bruger indputtet og bruger det videre til output.
        /// Static for at man kun behøver at oprette det en gang og det bruges,
        /// af alle funktioner.
        /// Readonly gør at man ikke kan overskrive den.
        /// </summary>
        private static readonly MenuManager menu = new(new RealConsole());

        /// <summary> /// Kalder bevægelse funktion fra MenuManager, samt hovedmenu /// </summary>
        static void Main()
        {
            menu.Navigate(BuildMainMenu()); //Kalder bevægelse funktion fra MenuManager, samt hovedmenu.
        }

        // Laver vores menuer.

        // Hovedmenu, 
        private static MenuPage BuildMainMenu() => new(
            "CAR MANAGEMENT MENU",
            new List<MenuItem>
            {
                new ("Car Owner Funktions",     () => menu.Push(CarOwnerMenu())),
                new ("Car Funktions",           () => menu.Push(CarFunktionsMenu())),
                new ("Trip Funktions",          () => menu.Push(TripFunktionsMenu())),
                new ("Print All Funktion",                 PromptDummy),


            }); // ); afslutter metode & constructor kaldet. Alt inde i new, er parametere.

        private static MenuPage CarOwnerMenu() => new(
            "CAR MANAGEMENT MENU \nCAR OWNER",
            new List<MenuItem>
            {
                new ("Add New Car Owner",    AddNewCarOwner),
                new ("Show Car Owners",      ShowCarOwners),
                new ("Remove A Car Owner",   RemoveCarOwner),
                new ("Choose Car Owner",     ChooseCarOwner),
                           
            });

        private static MenuPage CarFunktionsMenu() => new(
            "CAR MANAGEMENT MENU \nCARS",
            new List<MenuItem>
            {
                new ("Choose Car",           PromptDummy),
                new ("Show Car Stats",       PromptDummy),
                new ("Turn Engine On/Off",   PromptDummy),
                new ("Add Car",              PromptDummy),
                new ("Add Fuel to Car",      PromptDummy),
                new ("Change Tires On Car",  PromptDummy),
                new ("Get Car To Service",   PromptDummy),
                new ("Remove Car",           PromptDummy),
                          
            });

        private static MenuPage TripFunktionsMenu() => new(
            "CAR MANAGEMENT MENU \nTRIPS",
            new List<MenuItem>
            {
                new ("Take A Trip",                       PromptDummy),
                new ("Show Trips From Current Car",       PromptDummy),
                new ("Remove Trips",                      PromptDummy),

            });


        
        private static void AddNewCarOwner()
        {
            Console.Write("What is the Owners name: ");
            string name = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrEmpty(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Name cannot be empty.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                return;
            }
            carOwnerManager.AddCarOwner(name);
            Console.ReadLine();            
        }

        private static void ShowCarOwners()
        {
            Console.WriteLine("Show car owners");
            carOwnerManager.ShowCarOwners();
            Console.ReadLine();
            Console.Clear();            
        }

        private static void RemoveCarOwner()
        {
            Console.Write("Which owner do you want to remove? ");
            string ownerToRemove = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrEmpty(ownerToRemove))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Owner name cannot be empty.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                return;
            }
            carOwnerManager.RemoveCarOwner(ownerToRemove);
            Console.ReadLine();
            Console.Clear();
            
        }

        private static void ChooseCarOwner()
        {
            Console.Write("Enter the owner's name: ");
            string ownerName = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrEmpty(ownerName))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Owner name cannot be empty.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                return;
            }
            Console.WriteLine("This option is not done yet");
        }
        private static void PromptDummy()
        {
            Console.WriteLine("Det her er en dummy");
            Console.ReadKey();
        }
        //static void Main(string[] args)
        //{
        //    int choice;
        //    Menu menu = new Menu();

        //    do
        //    {
        //        menu.Usermenu();
        //        Console.ForegroundColor = ConsoleColor.Cyan;

        //        if (!int.TryParse(Console.ReadLine(), out choice))
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine("Invalid input, please enter a number.");
        //            Console.ForegroundColor = ConsoleColor.Cyan;
        //            continue;
        //        }

        //        Console.Clear();

        //        switch (choice)
        //        {
        //            case 1:
        //                HandleCarOwnerMenu(menu);
        //                break;
        //            case 2:
        //                HandleCarMenu(menu);
        //                break;
        //            case 3:
        //                HandleTripMenu(menu);
        //                break;
        //            case 4:
        //                //Skal have hele listen ind her.
        //                break;
        //            case 5:
        //                Console.WriteLine("Thank you for using car management system!");
        //                break;
        //            default:
        //                Console.ForegroundColor = ConsoleColor.Red;
        //                Console.WriteLine("Invalid Choice, Try Again!!");
        //                Console.ForegroundColor = ConsoleColor.Cyan;
        //                break;
        //        }
        //    } while (choice != 5);
        //}

        //static void HandleCarOwnerMenu(Menu menu)
        //{
        //    int ownerChoice;
        //    do
        //    {
        //        menu.CarOwnerMenu();
        //        Console.ForegroundColor = ConsoleColor.Cyan;

        //        if (!int.TryParse(Console.ReadLine(), out ownerChoice))
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine("Invalid input, please enter a number.");
        //            Console.ForegroundColor = ConsoleColor.Cyan;
        //            continue;
        //        }

        //        switch (ownerChoice)
        //        {
        //            case 1:
        //                Console.Write("What is the Owners name: ");
        //                string name = Console.ReadLine() ?? string.Empty;
        //                if (string.IsNullOrEmpty(name))
        //                {
        //                    Console.ForegroundColor = ConsoleColor.Red;
        //                    Console.WriteLine("Name cannot be empty.");
        //                    Console.ForegroundColor = ConsoleColor.Cyan;
        //                    break;
        //                }
        //                carOwnerManager.AddCarOwner(name);
        //                Console.ReadLine();
        //                Console.Clear();
        //                break;

        //            case 2:
        //                Console.WriteLine("Show car owners");
        //                carOwnerManager.ShowCarOwners();
        //                Console.ReadLine();
        //                Console.Clear();
        //                break;

        //            case 3:
        //                Console.Write("Which owner do you want to remove? ");
        //                string ownerToRemove = Console.ReadLine() ?? string.Empty;
        //                if (string.IsNullOrEmpty(ownerToRemove))
        //                {
        //                    Console.ForegroundColor = ConsoleColor.Red;
        //                    Console.WriteLine("Owner name cannot be empty.");
        //                    Console.ForegroundColor = ConsoleColor.Cyan;
        //                    break;
        //                }
        //                carOwnerManager.RemoveCarOwner(ownerToRemove);
        //                Console.ReadLine();
        //                Console.Clear();
        //                break;

        //            case 4:
        //                Console.Write("Enter the owner's name: ");
        //                string ownerName = Console.ReadLine() ?? string.Empty;
        //                if (string.IsNullOrEmpty(ownerName))
        //                {
        //                    Console.ForegroundColor = ConsoleColor.Red;
        //                    Console.WriteLine("Owner name cannot be empty.");
        //                    Console.ForegroundColor = ConsoleColor.Cyan;
        //                    break;
        //                }

        //                break;

        //            case 5:
        //                Console.WriteLine("Returning to main menu..");
        //                break;
        //        }

        //    } while (ownerChoice != 5);

        //    Console.Clear();
        //}

        //static void HandleCarMenu(Menu menu)
        //{
        //    int carChoice;
        //    do
        //    {
        //        Console.Clear();
        //        menu.CarMenu();
        //        Console.ForegroundColor = ConsoleColor.Cyan;

        //        if (!int.TryParse(Console.ReadLine(), out carChoice))
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine("Invalid input, please enter a number.");
        //            Console.ForegroundColor = ConsoleColor.Cyan;
        //            continue;
        //        }

        //        switch (carChoice)
        //        {
        //            case 1:
        //                Console.WriteLine("Hvilket bilmærke vil du tilføje?");
        //                string brand = Console.ReadLine() ?? string.Empty;

        //                Console.WriteLine("Hvilken model vil du tilføje?");
        //                string model = Console.ReadLine() ?? string.Empty;

        //                Console.WriteLine("Hvilket årstal er bilen fra?");
        //                int year = int.Parse(Console.ReadLine() ?? "0");

        //                Console.WriteLine("Hvor mange km/l kører bilen?");
        //                double kmPerLiter = double.Parse(Console.ReadLine() ?? "0");

        //                Console.WriteLine("Hvilken brændstof type bruger bilen? (Petrol, Diesel, Electric, Hybrid)");
        //                FuelType fuelType = (FuelType)Enum.Parse(typeof(FuelType), Console.ReadLine() ?? "0");

        //                Console.WriteLine("Hvor mange liter kan tanken indeholde?");
        //                double fuelTank = double.Parse(Console.ReadLine() ?? "0");

        //                var trips = new List<Trip>();
        //                carManager.AddCar(brand, model, year, kmPerLiter, fuelTank, fuelType, trips);
        //                Console.WriteLine($"Car added: {brand} {model} ({year}) - {kmPerLiter} km/l, {fuelType}");


        //                break;

        //            case 2:
        //                Console.WriteLine("Add fuel to car");
        //                break;

        //            case 3:
        //                Console.WriteLine("Change tires in car");
        //                break;

        //            case 4:
        //                Console.WriteLine("Car service");
        //                break;

        //            case 5:
        //                Console.WriteLine("Show cars");
        //                break;

        //            case 6:
        //                Console.WriteLine("Remove Car");
        //                break;

        //            case 7:
        //                Console.WriteLine("Choose car");
        //                break;

        //            case 8:
        //                Console.WriteLine("Turn engine on/off");
        //                break;

        //            case 9:
        //                Console.WriteLine("Returning to main menu..");
        //                break;
        //        }

        //    } while (carChoice != 9);


        //}

        //static void HandleTripMenu(Menu menu)
        //{
        //    int tripChoice;
        //    do
        //    {
        //        menu.TripMenu();
        //        Console.ForegroundColor = ConsoleColor.Cyan;

        //        if (!int.TryParse(Console.ReadLine(), out tripChoice))
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine("Invalid input, please enter a number.");
        //            Console.ForegroundColor = ConsoleColor.Cyan;
        //            continue;
        //        }

        //        switch (tripChoice)
        //        {
        //            case 1:
        //                Console.WriteLine("Add trip");
        //                break;

        //            case 2:
        //                Console.WriteLine("Remove trip");
        //                break;

        //            case 3:
        //                Console.WriteLine("Show trips");
        //                break;

        //            case 4:
        //                Console.WriteLine("Returning to main menu..");
        //                break;
        //        }

        //} while (tripChoice != 4);

        //    Console.Clear();
        //}
    }
}
