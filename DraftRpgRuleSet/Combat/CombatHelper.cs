using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DraftRpg.Combat
{
    public static class CombatHelper
    {
        /// <summary>
        /// See Draft 0.4 RPG Rule Set 4.17.5
        /// </summary>
        /// <param name="armor"></param>
        /// <returns></returns>
        public static int ArmorMovementPenalty(ArmorType armor)
        {
            int retval = 0;

            switch (armor)
            {
                case ArmorType.Chain:
                    retval = -1;
                    break;
                case ArmorType.Plate:
                    retval = -1;
                    break;
                case ArmorType.FullPlate:
                    retval = -2;
                    break;
                case ArmorType.CombatSuit:
                    retval = -2;
                    break;
            }

            return retval;
        }

        /// <summary>
        /// See Draft 0.4 RPG Rule Set 4.17.5
        /// </summary>
        /// <param name="armor"></param>
        /// <returns></returns>
        public static int ArmorProtection(ArmorType armor)
        {
            int retval = 0;

            switch (armor)
            {
                case ArmorType.HeavyCloth:
                    retval = 1;
                    break;
                case ArmorType.Leather:
                    retval = 2;
                    break;
                case ArmorType.Chain:
                    retval = 3;
                    break;
                case ArmorType.Plate:
                    retval = 4;
                    break;
                case ArmorType.FullPlate:
                    retval = 5;
                    break;
                case ArmorType.CombatSuit:
                    retval = 7;
                    break;
            }

            return retval;
        }

        /// <summary>
        /// See Draft 0.4 RPG Rule Set 4.19.1 
        /// </summary>
        /// <param name="size"></param>
        /// <param name="weaponBonus"></param>
        /// <returns></returns>
        public static int WeaponDamage(WeaponSize size, int weaponBonus)
        {
            /*  Formula:
             *  
             *  (impact x 2) + bonus 
             */

            int impact = (int)size;
            
            return impact * 2 + weaponBonus;
        }

        /// <summary>
        /// See Draft 0.4 RPG Rule Set 4.19
        /// </summary>
        /// <param name="attackRoll"></param>
        /// <param name="defenseRoll"></param>
        /// <param name="weaponDamage"></param>
        /// <param name="strengthBonus"></param>
        /// <param name="armorProtection"></param>
        /// <returns></returns>
        public static int AttackDamage(int attackRoll, int defenseRoll, int weaponDamage, int strengthBonus = 0, int armorProtection = 0)
        {
            /*  Forumla
             *  
                damage = attack roll - defense roll
                    + damage (impact x 2)
                    + strength bonus (7-8 = +1, 9-10 = +2)
                    - armor protection
            */

            return attackRoll - defenseRoll + strengthBonus + weaponDamage - armorProtection;
        }
    }
}
