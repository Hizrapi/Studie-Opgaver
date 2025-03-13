using System.Diagnostics.CodeAnalysis;

namespace Studie_opgaver
{
    internal class Program
    {
        /*
        //Opgave 1:
        enum StudySubject
        {
            Math,
            Danish,
            English,
            Sports,
            Programming
        }

        static void StudieOpgave(StudySubject subject)
        {
            switch (subject) 
            {
                case StudySubject.Math:
                    Console.WriteLine("Math: The study of numbers, shapes patterns.");
                    break;

                case StudySubject.Danish:
                    Console.WriteLine("Danish: The study of the danish language and literature.");
                    break;

                case StudySubject . English:
                    Console.WriteLine("English: The study of the English language and literature.");
                    break;
                case StudySubject.Sports:
                    Console.WriteLine("Sports: Physical activities and games.");
                    break;
                case StudySubject.Programming:
                    Console.WriteLine("Programming: The study of writing computer programs.");
                    break;
                default:
                    Console.WriteLine("Unknown subject.");
                    break;
            }
        }

        static void StudieOpgave()
        {
            StudySubject fagValg = StudySubject.Math;
            StudieOpgave(fagValg);
        }

        static void Main(string[] args)
        {
            StudieOpgave();
        }

    } */

        //Opgave 2 Arrayes

        static void Main(string[] args)
        {
            GenerateNumbers();
        }

        static void GenerateNumbers()
        {
            Random random = new Random();
            int[] randomNumbers = new int[10];
            int sum = 0;

            Console.Write("Array tal: [ ");

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = random.Next(1, 100);
                
                Console.Write($"{randomNumbers[i]}, ");
                sum += randomNumbers[i];
            }
            Console.Write("]");

            Console.WriteLine("");
            Console.WriteLine("Sum of random numbers: " + sum);
            Console.WriteLine("Gennemsnit: " + sum / 10);

            Array.Sort(randomNumbers);
            Console.Write("Sorted numbers: [ ");
            foreach (int number in randomNumbers)
            {
                Console.Write(number + ", ");
            }
            Console.Write("]");

        }

    }
}
