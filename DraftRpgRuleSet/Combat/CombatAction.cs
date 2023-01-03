using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftRpg.Combat
{
    public enum CombatAction
    {
        None = 0,
        Hit = 1,
        Parry = 2,
        Dodge = 4,
        Flee = 8
    }
}
