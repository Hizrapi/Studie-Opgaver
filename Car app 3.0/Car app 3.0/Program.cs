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
    }
}
