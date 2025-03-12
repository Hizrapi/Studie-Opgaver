using Dungeons___Dragons.Charecter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons___Dragons
{
    internal class Title
    {
        public void TitleMenu1()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=====================================================");
            Console.WriteLine("||             STAR WARS: A FORCE JOURNEY          ||");
            Console.WriteLine("=====================================================");
        }
        public void TitleMenu2(Character_stats character)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=====================================================");
            Console.WriteLine("||             STAR WARS: A FORCE JOURNEY          ||");
            Console.WriteLine("=====================================================");
            Console.WriteLine($" {character.CharacterName} {character.CharacterTitle} LV: {character.CharacterLevel} Life: {character.CurrentLife}/{character.MaxLife} Energy: {character.CurrentForceEnergy}/{character.MaxForceEnergy}");

            Console.WriteLine("=====================================================");
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
