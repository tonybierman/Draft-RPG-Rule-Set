using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftRpg.Combat
{
    public enum ArmorType
    {
        [Description("Unamored")] None,
        [Description("Heavy cloth")] HeavyCloth,
        [Description("Leather")] Leather,
        [Description("Chain mail")] Chain,
        [Description("Plate mail")] Plate,
        [Description("Full plate mail")] FullPlate,
        [Description("Combat suit")] CombatSuit
    }
}
