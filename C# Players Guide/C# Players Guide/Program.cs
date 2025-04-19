namespace C__Players_Guide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The Replicator of D'To - Hvordan for loops bliver brugt med arrays.
            //int[] original = new int[5];

            //for (int item = 0; item < 5; item++)
            //{
            //    Console.Write("Enter a number: ");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    original[item] = number;
            //}

            //int[] copy = new int[5];

            //for (int index = 0; index < 5; index++)
            //    copy[index] = original[index];

            //for (int index = 0; index < 5; index++)
            //    Console.WriteLine($"{original[index]} and {copy[index]}");

            //The Laws of Freach - Hvordan foreach loops er brugt.
            //int[] array = new int[] {4, 51, -7, 13, -99, 15, -8, 45, 90};

            //int currentSmallest = int.MaxValue;
            //foreach (int element in array) //(int index = 0; index < array.Length; index++)
            //{
            //    if (element < currentSmallest)
            //        currentSmallest = element;
            //}
            //Console.WriteLine(currentSmallest);

            //int total = 0;
            //foreach (int element in array) // (int index = 0; index < array.Length; index++)
            //    total += element;
            //    float average = (float)total / array.Length;
            //Console.WriteLine(average.ToString("F2"));

            //Taking a Number

            //int number = AskForNumberInRange("User 1, enter a number between 0 and 100:", 0, 100);

            //Console.Clear();

            //Console.WriteLine("User 2, guess the number.");

            //while (true)
            //{
            //    int guess = AskForNumber("What is your next guess?");
            //    if (guess > number) Console.WriteLine($"{guess} is too high.");
            //    else if (guess < number) Console.WriteLine($"{guess} is too low.");
            //    else break;
            //}

            //Console.WriteLine("You guessed the number!");


            //int AskForNumber(string text)
            //{
            //    Console.Write(text + " ");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    return number;
            //}

            //int AskForNumberInRange(string text, int min, int max)
            //{
            //    while (true)
            //    {
            //        int number = AskForNumber(text);
            //        if (number >= min && number <= max)
            //            return number;
            //    }
            //}
            DoubleAndAddOne(20);

            int DoubleAndAddOne(int value)

            {
                return value * 2 + 1;

            }
            

        }
    }
}
