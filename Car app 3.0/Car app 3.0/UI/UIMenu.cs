using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_app_3._0.UI
{
    /// <summary> UIMenu indholder kun ting om der skal vises.. </summary>
    public static class UIMenu
    {
        public static void DrawMenu(IConsole con, MenuPage page, int selectedIndex)
        {
            con.Clear();

            var titleLines = string.IsNullOrEmpty(page.Title) ? new string[0] : page.Title.Split('\n');
            int titleWidth = titleLines.Any() ? titleLines.Max(l => l.Length) : 0;
            int menuWidth = page.Items.Any() ? page.Items.Max(i => i.Text.Length) + 10 : 0;

            int boxWidth = Math.Max(titleWidth, menuWidth);

            // Tegn titel (hvis den findes) med fælles bredde
            if (titleLines.Any())
                DrawTitleBox(con, page.Title, boxWidth);

            // Tegn menu-ramme
            con.WriteLine($"╔{new string('═', boxWidth)}╗");

            for (int i = 0; i < page.Items.Count; i++)
            {
                string text = page.Items[i].Text;
                string line = $"║  {text.PadRight(boxWidth - 4)}  ║";

                if (i == selectedIndex)
                {
                    con.BackgroundColor = ConsoleColor.DarkBlue;
                    con.ForegroundColor = ConsoleColor.White;
                }

                con.WriteLine(line);
                con.ResetColor();
            }

            con.WriteLine($"╚{new string('═', boxWidth)}╝");

            con.WriteLine("\n↑/↓ = flyt, Enter = vælg, Esc = tilbage");
        }

        //public static void DrawMenu(IConsole con, MenuPage page, int selectedIndex)
        //{
        //    con.Clear(); //Skærmen rydes

        //    // Tegner titelbox hvis der er titel -> metode længere nede.
        //    if (!string.IsNullOrEmpty(page.Title))
        //    {
        //        DrawTitleBox(con, page.Title);
        //    }

        //    int boxWidth = page.Items.Max(i => i.Text.Length) + 10; //Finder den længste tekst i menuen, og ligger 10 oven i
        //    con.WriteLine("╔" + new string('═', boxWidth) + "╗"); //Tegner øverste ramme

        //    //Tegner hvert menupunkt, en linje ad gangen
        //    for (int i = 0; i < page.Items.Count; i++)
        //    {
        //        string line = $"║  {page.Items[i].Text.PadRight(boxWidth - 4)}  ║";

        //        if (i == selectedIndex) //Giver farven til det markerede felt.
        //        {
        //            con.BackgroundColor = ConsoleColor.DarkBlue;
        //            con.ForegroundColor = ConsoleColor.White;
        //        }

        //        con.WriteLine(line);
        //        con.ResetColor();
        //    }

        //    con.WriteLine("╚" + new string('═', boxWidth) + "╝"); //Tegner nederste ramme
        //    con.WriteLine("\n↑/↓ = flyt, Enter = vælg, Esc = tilbage"); //Forklaring til brug
        //}

        //Hvis der er en titel box, bliver boxen lavet her.
        private static void DrawTitleBox(IConsole con, string title, int boxWidth)
        {
            var lines = title.Split('\n');                      // Del op i linjer
            con.ForegroundColor = ConsoleColor.Yellow;
            con.WriteLine($"╔{new string('═', boxWidth)}╗");

            foreach (var line in lines)
            {
                int padding = boxWidth - line.Length;               
                int padLeft = padding / 2;                              // 2 for kanten og mellemrum
                int padRight = boxWidth - padLeft - line.Length;        // Resten til højre

                string centeredLine = "║" + new string(' ', padLeft) + line + new string(' ', padRight) + "║";
                con.WriteLine(centeredLine);
            }

            con.WriteLine($"╚{new string('═', boxWidth)}╝");
            con.ResetColor();
        }

        //private static void DrawTitleBox(IConsole con, string title)
        //{
        //    var lines = title.Split('\n');                          // Del op i linjer
        //    int maxTextWidth = lines.Max(l => l.Length);           // Find længste linje
        //    int boxWidth = maxTextWidth + 4;                       // Tilføj 4 til boksen (2 mellemrum + 2 kantstreger)

        //    con.ForegroundColor = ConsoleColor.Yellow;
        //    con.WriteLine($"╔{new string('═', boxWidth)}╗");

        //    foreach (var line in lines)
        //    {
        //        int padding = maxTextWidth - line.Length;
        //        int padLeft = padding / 2 + 2;                     // 2 for kanten og mellemrum
        //        int padRight = boxWidth - padLeft - line.Length;  // Resten til højre

        //        string centeredLine = "║" + new string(' ', padLeft) + line + new string(' ', padRight) + "║";
        //        con.WriteLine(centeredLine);
        //    }

        //    con.WriteLine($"╚{new string('═', boxWidth)}╝");
        //    con.ResetColor();
        //}

    }
}
