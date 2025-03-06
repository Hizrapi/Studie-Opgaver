namespace Car_app_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.ReadCarDetails();
            Console.WriteLine("Biloplysninger indlæst!");
            Console.ReadLine();
            Console.Clear();

            int choice;
            do
            {
                Console.WriteLine("0. Toogle Engine on/off");
                Console.WriteLine("1. Read Car Details");
                Console.WriteLine("2. Drive");
                Console.WriteLine("3. Caculate Trip Price");
                Console.WriteLine("4. IsPalindrome");
                Console.WriteLine("5. Print car Details");
                Console.WriteLine("6. Print All Team Cars");
                Console.WriteLine("7. Exit");
                Console.Write("Indtast dit valg: ");

                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Indtast 'true' for at tænde motoren, 'false' for at slukke motoren:");
                        bool turnOn = bool.Parse(Console.ReadLine());
                        car.ToggleEngine(turnOn);
                        Console.WriteLine("");
                        break;
                    case 1:
                        car.ReadCarDetails();
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.Write("Indtast afstand: ");
                        double distance = double.Parse(Console.ReadLine());
                        car.Drive(distance);
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("Indtast afstand:");
                        distance = double.Parse(Console.ReadLine());
                        Console.WriteLine("Indtast literpris:");
                        double literPrice = double.Parse(Console.ReadLine());
                        double price = car.CalculateTripPrice(distance, literPrice);
                        Console.WriteLine($"Prisen for turen er: {price}");
                        Console.WriteLine("");
                        break;
                    case 4:
                        Console.WriteLine("Indtast kilometerstand:");
                        int km = int.Parse(Console.ReadLine());
                        bool isPalindrome = car.IsPalindrome(km);
                        Console.WriteLine($"Er kilometerstanden et palindrom? {isPalindrome}");
                        Console.WriteLine("");
                        break;
                    case 5:
                        car.PrintCarDetails();
                        Console.WriteLine("");
                        break;
                    case 6:
                        car.PrintAllTeamCars();
                        Console.WriteLine("");
                        break;
                    case 7:
                        Console.WriteLine("Afslutter programmet. God dag!!!");
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg, prøv igen.");
                        Console.WriteLine("");
                        break;
                }
            } while (choice != 7);
        }
    
        
    }
}
