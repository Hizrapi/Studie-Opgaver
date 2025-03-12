using Dungeons___Dragons.Charecter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons___Dragons.Menuer
{
    internal class New_game
    {
        public void choiceSide(Character_stats character) // Skal have gjort sådan at De 2 variabler bliver gemt, i Character.
        {
            // ... (rest of the code remains unchanged)

            Console.Write("Indtast dit navn og begynd din rejse: ");
            string characterName = Console.ReadLine() ?? string.Empty; // Handle possible null value
            character.CharacterName = characterName; // Save the character name to the Character_stats object
            Console.Clear();

            // ... (rest of the code remains unchanged)

            Console.Write("Vælg nu mellem [D]ark eller [L]ight side: ");
            string? input = Console.ReadLine();
            char forcechoice = input != null && input.Length > 0 ? input[0] : ' '; // Handle possible null value
            character.ForceChoice = forcechoice; // Save the force choice to the Character_stats object

            do
            {
                if (forcechoice == 'L')
                {
                    Console.WriteLine("\nGodt valg, youngling. Med dette skridt træder du ind på en vej fyldt med håb og styrke. ");
                    Console.WriteLine("Du har valgt balancen, valgt at beskytte de svage og bringe lys til mørket.  \n");
                    Console.WriteLine("Dette valg markerer begyndelsen på din rejse mod at blive en ægte Jedi-mester. ");
                    Console.WriteLine("Men husk, det kræver tålmodighed, mod og en vilje til at konfrontere både ydre og ");
                    Console.WriteLine("indre kampe. Lyset er med dig, hvis du lader det lede din vej.");
                    break;
                }
                else if (forcechoice == 'D')
                {
                    Console.WriteLine("Interessant valg. Du har valgt at følge en sti, der kræver styrke, passion og en vilje til at ");
                    Console.WriteLine("forme din egen skæbne. Med dette valg omfavner du din kraft og lader intet og ingen begrænse dig. ");
                    Console.WriteLine("Mørket byder dig velkommen, men vær klar til at kæmpe for din frihed og din magt. Du har taget det ");
                    Console.WriteLine("første skridt mod at blive noget, som selv stjernerne vil frygte. Galaksen vil aldrig være den samme.");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input, try again");
                    Console.Write("Vælg nu mellem [D]ark eller [L]ight side: ");
                    input = Console.ReadLine();
                    forcechoice = input != null && input.Length > 0 ? input[0] : ' '; // Handle possible null value
                }
            }
            while (true);
            Console.ReadKey();
            Console.Clear();
            Gameplay_Menu gameplay_Menu = new Gameplay_Menu();
            gameplay_Menu.gameplayMenu(character);
        }
    }
}
