using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DraftRpgRuleSet.Combat
{
    public static class CombatHelper
    {
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
            
            return impact  * 2 + weaponBonus;
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
                    + strength bonus (7-8 = +1, 9-10 = +2)
                    + damage bonus (impact x 2) + bonus
                    - armor protection
            */

            return attackRoll - defenseRoll + strengthBonus + weaponDamage - armorProtection;
        }
    }
}
