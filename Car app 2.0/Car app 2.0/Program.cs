namespace Car_app_2._0
{
    internal class Program
    {
        class Car                                       // Er lidt som en pakke toiletpapir
        {
            public string brand;
            public string model;
            public int year;
            public double odometer;
            public double kmPerLiter;
            public char brændStofType;
            public bool isEngineOn;

            public void ReadCarDetails()                // hver method er som toiletpapiret i pakken
            {
                Console.Write("Indtast bilens mærke: ");
                brand = Console.ReadLine();

                Console.Write("Indtast bilens model: ");
                model = Console.ReadLine();

                Console.Write("Indtast bilens årgang: ");
                year = int.Parse(Console.ReadLine());

                Console.Write("Indtast bilens kilometerstand: ");
                odometer = double.Parse(Console.ReadLine());

                Console.Write("Indtast bilens Brændstoff type [E]l, [B]enzin og [D]iesel: ");
                brændStofType = char.Parse(Console.ReadLine());

                Console.Write("Indtast bilens brændstofforbrug: ");
                kmPerLiter = double.Parse(Console.ReadLine());

                
                isEngineOn = false; //Motoren er slukket til at starte med.
            }

            public void ToggleEngine(bool turnOn)        // method bool til at tænde og slukke motor.
            {
                isEngineOn = turnOn;
                if (isEngineOn)
                {
                    Console.WriteLine("Motoren er nu tændt.");
                }
                else
                {
                    Console.WriteLine("Motoren er nu slukket.");
                }
            }
            public void Drive(double distance)          // method til at regne kilometerstand. (distance deffineres i Main)
            {
                if (isEngineOn)                         // Er motoren tændt  
                {
                    odometer += distance;               // += betyder at ligger distancen op i total puljen
                    Console.WriteLine($"Du har kørt {distance} km. Ny kilometerstand: {odometer} km.");
                }
                else                                    // Hvis den er slukket så gør.
                {
                    Console.WriteLine("Motoren er ikke tændt. Tænd motoren først.");
                }
            }

            public double CalculateTripPrice(double distance, double literPrice) // variable man skriver i parentes kan bruges når den loader i Main()
            {
                if (kmPerLiter == 0)                    // Et loop, søger for at man ikke skriver 0.
                {
                    Console.WriteLine("Km per liter kan ikke være 0.");
                    return 0;
                }

                double litersUsed = distance / kmPerLiter;
                double tripPrice = litersUsed * literPrice;
                return tripPrice;                       // Skriver variablen ud.
            }

            public bool IsPalindrome(int km)            //Palindrome svært at forstå, men tror om det er tallet er ulligt eller lige.
            {
                string kmStr = km.ToString();
                int len = kmStr.Length;

                for (int i = 0; i < len / 2; i++)
                {
                    if (kmStr[i] != kmStr[len - i - 1])
                    {
                        return false;
                    }
                }

                return true;
            }

            public void PrintCarDetails()                       // Printer bilens mærker
            {
                Console.WriteLine($"Bilens mærke: {brand}");
                Console.WriteLine($"Bilens model: {model}");
                Console.WriteLine($"Bilens årgang: {year}");
                Console.WriteLine($"Bilens kilometerstand: {odometer}");
                Console.WriteLine($"Bilens km per liter: {kmPerLiter}");
            }

            public void PrintAllTeamCars()
            {
                List<Car> teamCars = new List<Car>              // Printer denne liste af info, Kan jeg mon gemme printcardetails i den?
                {
                    new Car { brand = "Toyota", model = "Corolla", year = 2020, odometer = 15000, kmPerLiter = 15 },
                    new Car { brand = "Honda", model = "Civic", year = 2018, odometer = 20000, kmPerLiter = 14 },
                    new Car { brand = "Ford", model = "Focus", year = 2019, odometer = 18000, kmPerLiter = 13 },
                    new Car { brand = "Toyota", model = "Yaris", year = 2018, odometer = 120000, kmPerLiter = 18 }
                };

                foreach (Car car in teamCars)
                {
                    car.PrintCarDetails();
                    Console.WriteLine();
                }

            }
        }
        static void Main(string[] args)
        {
            Car car = new Car(); // Kalder classen  Car, som skrevet foroven til at kunne blive brugt her.
            car.ReadCarDetails();
            Console.WriteLine("Biloplysninger indlæst!");
            Console.ReadLine();
            Console.Clear();

            int choice;
            do // Starter et loop, der slutter hvis choice får en færdig af 7 og derfor er loopet falsk
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

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Indtast 'true' for at tænde motoren, 'false' for at slukke motoren:");
                        bool turnOn = bool.Parse(Console.ReadLine());
                        car.ToggleEngine(turnOn);
                        Console.WriteLine("");
                        break;
                    case 1:
                        car.ReadCarDetails();// skal indlæse ReadCarDetails() mærke, model, årgang, km-tilstand osv)
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.Write("Indtast afstand: ");
                        double distance = double.Parse(Console.ReadLine());
                        car.Drive(distance); // Skal tjekke om bilen er tændt. Hvis den er tændt skal man kunne opdatere bilens km-tilstand
                        Console.WriteLine("");
                        break;
                    case 3:
                        // Beregn en pris for en køretur ud på kmPerLiter & Benzin, Diesel eller el pris.
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
                        Console.WriteLine($"Er kilometerstanden et palindrom? {isPalindrome}"); // ISplaindrome ved ikke helt hvad det er.
                        Console.WriteLine("");
                        break;
                    case 5:
                        car.PrintCarDetails(); // print bilens oplysninger odometer, kmPerLiter
                        Console.WriteLine("");
                        break;
                    case 6:
                        car.PrintAllTeamCars(); // print alle bilerne for hele vores hold.
                        Console.WriteLine("");
                        break;
                    case 7:
                        Console.WriteLine("Afslutter programmet. God dag!!!"); // Afslutter programmet
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg, prøv igen."); // ugyldigt valg
                        Console.WriteLine("");
                        break;
                }
            } while (choice != 7);
        }
        
    }
}
