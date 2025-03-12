using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons___Dragons.Charecter
{
    internal class Dark_side
    { 

        public string GetTitle(int level)
        {
            if (level < 10)
            {
                return "Acolyte";
            }
            else if (level >= 10 && level < 20)
            {
                return "Sith Aprentice";
            }
            else if (level >= 20 && level < 30)
            {
                return "Sith Warrior";
            }
            else if (level >= 30 && level < 40)
            {
                return "Sith Lord";
            }
            else if (level >= 40 && level < 50)
            {
                return "Sith Marauder";
            }
            else
            {
                return "Dark Lord of the Sith";
            }
        }

        

    }
}
