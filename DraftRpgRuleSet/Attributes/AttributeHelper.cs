using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftRpg.Attributes
{
    public static class AttributeHelper
    {
        /// <summary>
        /// See Draft 0.4 RPG Rule Set 4.19
        /// </summary>
        /// <param name="sa"></param>
        /// <returns></returns>
        public static int SalientAttributeBonus(int sa)
        {
            /*  Formula:
             *  
             *  (1-2 = -1, 7-8 = +1, 9-10 = +2)
             */

            int retval = 0;

            if (sa > 6)
                retval++;

            if (sa > 8)
                retval++;

            if (sa < 3)
                retval--;

            return retval;
        }
    }
}
