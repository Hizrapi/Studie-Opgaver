using System.Threading.Channels;

namespace Dungeons___Dragons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INTRO SCREEN
            Intro_Screen introScreen = new Intro_Screen();
            introScreen.introText();
            Console.ReadKey();
            Console.Clear();


            // START MENU
            Start_menu startMenu = new Start_menu();
            startMenu.preGameMenu();
        }
    }
}
