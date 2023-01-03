using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftRpg.Skills
{
    public static class SkillsHelper
    {
        public static bool SkillCheck(int skill, int bonus, int penalty, int dieRoll, int difficulty)
        {
            /*
             * Skill + Bonuses - Penalties + d10 > Difficulty
             */

            return skill + bonus - penalty + dieRoll > difficulty;
        }
    }
}
