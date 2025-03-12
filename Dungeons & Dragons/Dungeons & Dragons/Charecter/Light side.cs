using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons___Dragons.Charecter
{
    internal class Light_side: Character_stats
    {
        public string GetTitle(int level)
        {
            if (level < 10)
            {
                return "Youngling";
            }
            else if (level >= 10 && level < 20)
            {
                return "Padawan";
            }
            else if (level >= 20 && level < 30)
            {
                return "Jedi Knight";
            }
            else if (level >= 30 && level < 40)
            {
                return "Jedi Master";
            }
            else if (level >= 40 && level < 50)
            {
                return "Counsil Member";
            }
            else
            {
                return "Grand Master";
            }
        }
    }
}
