using System.Reflection;

namespace CarApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Øvelse 3 Udskrivning til Konsollen

            /*
            string brand = "Ford";
            string model = "GT";
            int year = 2022;
            char gearType = 'A';

            Console.WriteLine("Bilmærke: " + brand);
            Console.WriteLine("Bilmodel: " + model);
            Console.WriteLine("Årgang: " + year);
            Console.WriteLine("Gear: " + gearType);
            */

            //Øvelse 4: Brugerinput

            /*
            Console.Write("Indtast bilmærke ");
            String brand2 = Console.ReadLine();
            Console.Write("Indtast model ");
            String model2 = Console.ReadLine();
            Console.Write("Indtast årgang ");
            int year2 = int.Parse(Console.ReadLine());
            Console.Write("Indtast Geartype (Brug A eller M) ");
            char gearType2 = char.Parse(Console.ReadLine());
           
            Console.WriteLine();
            Console.WriteLine("Bilmærke: " + brand2);
            Console.WriteLine("Bilmodel: " + model2);
            Console.WriteLine("Årgang: " + year2);
            Console.WriteLine("Gear: " + gearType2);

            */

            //Øvelse 5: Kombinere Bilens Oplysninger i En sætning

            /*
            Console.Write("Indtast bilmærke ");
            String brand3 = Console.ReadLine();
            Console.Write("Indtast model ");
            String model3 = Console.ReadLine();
            Console.Write("Indtast årgang ");
            int year3 = int.Parse(Console.ReadLine());
            Console.Write("Indtast Geartype (Brug A eller M) ");
            char gearType3 = char.Parse(Console.ReadLine());

            Console.WriteLine($"{brand3} {model3} fra {year3} har gear: gearType3");

            */

            // Dag 2 Øvelse 1          
            /*

            Console.Write("Hvad er bilens Brandstoftype? ");
            var brandType = Console.ReadLine();
            Console.Write("Hvor langt kører den pr. liter? ");
            var KMprLiter = Console.ReadLine();
            Console.Write("Hvor langt har bilen kørt indtil videre? ");
            var Kilometerstand = Console.ReadLine();

            Console.Write($"Bilen er af brandstoftype {brandType} og kører {KMprLiter} pr. liter, og har en totalt kørsel på {Kilometerstand}KM");

            */
            // Dag 2 Øvelse 1.2, 1.3 & 1.4.
            /*
            Console.Write("Hvad er bilens Brandstoftype? ");
            string brandType = Console.ReadLine();
            Console.Write("Hvor langt kører den pr. liter? ");
            double KMprLiter = double.Parse(Console.ReadLine());
            Console.Write("Hvor langt har bilen kørt indtil videre? ");
            int Kilometerstand = int.Parse(Console.ReadLine());

            Console.Write($"Bilen er af brandstoftype {brandType} og kører {KMprLiter} pr. liter, og har en totalt kørsel på {Kilometerstand}KM");
            
            Console.ReadLine();

            Console.Clear();

            Console.Write("Hvor lang en køretur skal du ud på? ");
            double driveLength = double.Parse(Console.ReadLine());
            double priceLiter = 13.49; // Benzin, viderudvikle med If statement.
            double gasNeed = driveLength / KMprLiter;
            double drivePrice = gasNeed * priceLiter;
            double nyKilometerstand = Kilometerstand + driveLength;

            Console.WriteLine($"Din tur vil koste dig, {drivePrice:F2} kr. samt bilens nye kilometer stand vil være på {nyKilometerstand} km. "); // :F2
            */
            // Dag 2 Øvelse
            
            string carBrand = "Bilmærke";
            string model = "Model";
            string miles = "KM";
            string move = "";
            int totalWidth = 20;

            string move2 = move.PadRight(10);

            Console.Write("Vælg et bil mærke. ");
            string valgtbilmærke = Console.ReadLine();
            Console.Write("Vælg en model. ");
            string chooseModdel = Console.ReadLine();
            Console.Write("Angiv kilometertal. ");
            int chooseMiles = int.Parse(Console.ReadLine());
            string chooseMiles2 = chooseMiles.ToString();

            Console.WriteLine($"|{carBrand.PadRight(10)}|{model.PadRight(10)}|{miles.PadRight(10)}|");
            Console.WriteLine("".PadRight(89, '-'));
            Console.WriteLine($"|{valgtbilmærke.PadRight(10)}|{chooseModdel.PadRight(10)}|{chooseMiles2.PadRight(10)}|");



            string text = "Centreret";
            

            string centeredText = text.PadLeft((totalWidth + text.Length) / 2).PadRight(totalWidth);
            Console.WriteLine($"|{centeredText}|");



        }
    }
}

