using Dungeons___Dragons.Charecter;
using Dungeons___Dragons.Menuer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons___Dragons
{
    internal class Start_menu
    {
        public void preGameMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("==============================================");
            Console.WriteLine("          STAR WARS: A FORCE JOURNEY        ");
            Console.WriteLine("==============================================\n");
            Console.ResetColor();

            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("             1. START NEW GAME ");
            Console.WriteLine("             2. LOAD OLD GAME");
            Console.WriteLine("             3. SEE SCOREBOARD");
            Console.WriteLine("             4. EXIT GAME\n");
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("==============================================\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Please pick you choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Start new game
                    Character_stats character = new Character_stats();
                    New_game new_Game = new New_game();
                    Console.Clear();
                    new_Game.choiceSide(character);
                    break;

                case 2:
                    // LOAD OLD GAME
                    break;

                case 3:
                    // SEE SCOREBOARD
                    break;

                case 4:// Exit funktion
                    Console.WriteLine("Exiting the game... May the force be with you");
                    Environment.Exit(0);
                    break;

                default: // Fejl tastning
                    Console.WriteLine("Invalid choide. Please pick a valid option.");
                    break;
            }

                 
        }
        
    }
}
