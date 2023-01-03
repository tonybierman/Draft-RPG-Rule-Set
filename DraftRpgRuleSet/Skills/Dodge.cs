using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftRpg.Skills
{
    public class Dodge : IDraftRpgSkill
    {
        public RpgSkill Skill { get; private set; }

        public int Value { get; set; }

        public Dodge() 
        {
            this.Skill = RpgSkill.Dodge;
        }
    }
}
