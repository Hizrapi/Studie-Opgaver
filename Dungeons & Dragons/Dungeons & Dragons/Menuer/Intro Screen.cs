using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons___Dragons
{
    internal class Intro_Screen
    {
        public void introText()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("==============================================");
            Console.WriteLine("          STAR WARS: A FORCE JOURNEY        ");
            Console.WriteLine("==============================================");
            Console.WriteLine("\n           THIS GAME IS CREATED BY: \n        ");
            Console.WriteLine("           MARTIN HERSOM LINDECRONA  \n     ");
            Console.WriteLine("    DURING DATAMATIKER STUDY FIRST SEMESTER  \n   ");
            Console.WriteLine("                      2025         \n         ");
            Console.WriteLine("==============================================");
            Console.WriteLine("              HOPE YOU WILL ENJOY!!             ");
            Console.WriteLine("==============================================");
            Console.ResetColor();
        }
    }
}
