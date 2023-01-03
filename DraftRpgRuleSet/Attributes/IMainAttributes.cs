using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftRpg.Attributes
{
    public interface IMainAttributes
    {
        #region Physical Attributes

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }

        #endregion

        #region Mental Attributes

        public int Reason { get; set; }
        public int Intuition { get; set; }
        public int Willpower { get; set; }

        #endregion

        #region Interactive Attributes

        public int Charisma { get; set; }
        public int Perception { get; set; }
        public int Empathy { get; set; }

        #endregion

    }
}
