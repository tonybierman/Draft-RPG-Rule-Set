using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftRpg.Attributes
{
    public enum MainAttribute
    {
        [Description("Strength")] STR,
        [Description("Dexterity")] DEX,
        [Description("Constitution")] CON,
        [Description("Reason")] REA,
        [Description("Intuition")] INT,
        [Description("Willpower")] WIL,
        [Description("Charisma")] CHA,
        [Description("Perception")] PER,
        [Description("Empathy")] EMP
    }
}
