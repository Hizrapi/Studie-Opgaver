using Dungeons___Dragons.Charecter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons___Dragons.Menuer
{
    internal class Gameplay_Menu
    {
        public void gameplayMenu(Character_stats character)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=====================================================");
            Console.WriteLine("||             STAR WARS: A FORCE JOURNEY          ||");
            Console.WriteLine("=====================================================");
            Console.WriteLine($" {character.CharacterName} {character.CharacterTitle} LV: {character.CharacterLevel} Life: {character.CurrentLife}/{character.MaxLife} Energy: {character.CurrentForceEnergy}/{character.MaxForceEnergy}");

            Console.WriteLine("=====================================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                  Choose your Path");
            Console.WriteLine("               ======================");
            Console.WriteLine("                    [T]raining");
            Console.WriteLine("                   Do a [Q]uest");
            Console.WriteLine("                  Create [I]tems");
            Console.WriteLine("                [M]editate / Rage");
            Console.WriteLine("               See [C]haracter Stats");
            Console.WriteLine("                   [S]ave Game");
            Console.WriteLine("               [E]xit To Start Menu");
            Console.Write("\nWhat do you Choose?: ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input. Please enter a valid option.");
                return;
            }
            char gameplayMenuChoice = input[0];
            switch (gameplayMenuChoice)
            {
                case 'T':
                    // Add logic for Training
                    break;
                case 'Q':
                    // Add logic for Quest
                    break;
                case 'I':
                    // Add logic for Create Items
                    break;
                case 'M':
                    // Add logic for Meditate / Rage
                    break;
                case 'S':
                    // Add logic for Save Game
                    break;
                case 'E':
                    // Add logic for Exit To Start Menu
                    Console.WriteLine($"See you {character.CharacterName} May the Force be with you!!");
                    Console.ReadKey();
                    Console.Clear();
                    Start_menu startMenu = new Start_menu();
                    startMenu.preGameMenu();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }

            Console.ReadKey();
        }

    }
}
